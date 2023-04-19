using WordQuiz.Data;
using WordQuiz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.SignalR;
using WordQuiz.Data.Repositories;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordQuiz.Controllers
{
    //[Authorize(Roles = "Player, Admin")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WordController : ControllerBase
    {   
        IWordRepository wrd;
        IWordStaticRepository wrdst;
        ITopicRepository tp;

        private readonly UserManager<Player> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public WordController(IWordStaticRepository wrdst, IWordRepository wrd, ITopicRepository tp, UserManager<Player> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.wrd = wrd;
            this.wrdst = wrdst;
            this.tp = tp;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IWordRepository Wrd { get => wrd; set => wrd = value; }

        public UserManager<Player> UserManager => userManager;

        public RoleManager<IdentityRole> RoleManager => roleManager;

        #region Probably never used endpoints
        //// GET: api/<WordController>
        //[HttpGet("all")]
        //public async Task<IEnumerable<Word>> GetAllWord()
        //{
        //    return await wrd.GetAllWords();
        //}

        //// GET api/<WordController>/5
        //[HttpGet("{id}")]
        //public Word? GetWord(string id)
        //{
        //    return wrd.GetWordById(id).Result;
        //}

        // GET api/<WordController>/ExportWords
        //[HttpGet("ExportWords")]
        //public async Task<ActionResult> ExportWords()
        //{
        //    /*var words = await wrd.GetAllWords();
        //    var serializedWords = JsonConvert.SerializeObject(words, Formatting.Indented);

        //    */
        //    /*
        //    return Ok(await wrd.GetAllWords());


        //    */

        //    var words = await wrd.GetAllWords();
        //    var options = new JsonSerializerOptions { WriteIndented = true };
        //    var jsonString = System.Text.Json.JsonSerializer.Serialize(words, options);

        //    return Ok(jsonString);
        //}
        #endregion

        // POST api/<WordController>
        [HttpPost]
        public async void AddWord([FromBody] Word value)
        {

            await wrd.CreateWord(value);
        }

        // PUT api/<WordController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditWord(int id, [FromBody] Word value)
        {

            await wrd.UpdateWord(value);
            return Ok();
        }

        // DELETE api/<WordController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWord(string id)
        {
            await wrd.DeleteWord(id);
            return Ok();

        }


        // POST: api/<WordController>/StartGame
        [HttpPost("StartGame")]
        public async Task<ActionResult<IEnumerable<Word>>> StartGame([FromBody] string[] topicIds, int numberOfWords = 10)
        {
            
            // Get words from the provided topics
            var wordsFromTopics = new List<Word>();
            foreach (var topicId in topicIds)
            {
                var words = await wrd.GetWordsByTopicIdAsync(topicId);
                wordsFromTopics.AddRange(words);
            }

            numberOfWords = Math.Min(numberOfWords, wordsFromTopics.Count);

            // Select random words from the wordsFromTopics list
            var random = new Random();
            var selectedWords = new List<Word>();
            for (int i = 0; i < numberOfWords; i++)
            {
                int randomIndex = random.Next(0, wordsFromTopics.Count);
                selectedWords.Add(wordsFromTopics[randomIndex]);
                wordsFromTopics.RemoveAt(randomIndex);
            }

            return Ok(selectedWords.Select(w => w.Original));
        }


        [HttpPost("StartGameWeighted")]
        public async Task<ActionResult<IEnumerable<Word>>> StartGameWeighted([FromBody] List<string> topicIds, string player, int numberOfWords = 10)
        {
            // Get words from the provided topics
            var wordsFromTopics = new List<Word>();
            foreach (var topicId in topicIds)
            {
                var words = await wrd.GetWordsByTopicIdAsync(topicId);
                wordsFromTopics.AddRange(words);
            }

            numberOfWords = Math.Min(numberOfWords, wordsFromTopics.Count);

            // Get word statistics for the current player
            var currentPlayerStats = wrdst.GetAllAsync().Result.Where(x => x.Player.PlayerName.Equals(player));

            // Calculate the total weight of all the words
            int totalWeight = currentPlayerStats.Sum(w => w.Score);

            // Select random words from the wordsFromTopics list based on the weight
            var random = new Random();
            var selectedWords = new List<Word>();
            for (int i = 0; i < numberOfWords; i++)
            {
                int randomNumber = random.Next(1, totalWeight + 1);
                int cumulativeWeight = 0;

                foreach (var word in wordsFromTopics)
                {
                    var wordStat = currentPlayerStats.FirstOrDefault(ws => ws.Word.Id == word.Id);
                    int wordWeight = wordStat != null ? wordStat.Score : 0;
                    cumulativeWeight += wordWeight;

                    if (randomNumber <= cumulativeWeight)
                    {
                        selectedWords.Add(word);
                        wordsFromTopics.Remove(word);
                        totalWeight -= wordWeight;
                        break;
                    }
                }
            }

            return Ok(selectedWords.Select(w => w.Original));
        }


        // POST: api/<WordController>/end
        [HttpPost("end")]
        public async Task<ActionResult<Dictionary<string, bool>>> EndGame([FromBody] Dictionary<string, string> guesses)
        {
            Dictionary<string, bool> results = new Dictionary<string, bool>();

            foreach (var guess in guesses)
            {
                var word = await wrd.GetWordById(guess.Key);
                if (word != null)
                {
                    results.Add(guess.Key, word.Translation.Equals(guess.Value, StringComparison.OrdinalIgnoreCase));

                    // Update the word statistics
                    var wordStatistic = await wrdst.GetByIdAsync(guess.Key);
                    if (wordStatistic != null)
                    {
                        wordStatistic.Score = results[guess.Key] ? wordStatistic.Score + 1 : wordStatistic.Score - 1;
                        await wrdst.UpdateAsync(wordStatistic);
                    }
                }
            }

            return Ok(results);
        }

        // POST api/<WordController>/ImportWords
        [HttpPost("ImportWords")]
        public async Task<IActionResult> ImportWords([FromBody] List<Word> words)
        {
            foreach (var word in words)
            {
                // Check if the topic exists
                var existingTopic = await tp.GetTopicById(word.TopicId);

                // If the topic doesn't exist, create it
                if (existingTopic == null)
                {
                    // If the Topic object is provided, use it to create the topic
                    if (word.Topic != null)
                    {
                        var newTopic = new Topic
                        {
                            Id = word.Topic.Id,
                            Title = word.Topic.Title,
                            Description = word.Topic.Description
                        };

                        await tp.AddTopic(newTopic);
                        existingTopic = newTopic;
                    }
                    else
                    {
                        return BadRequest($"Topic with ID '{word.TopicId}' not found.");
                    }
                }

                // Set the Topic property of the word to the existing topic
                word.Topic = existingTopic;

                // Check if the word already exists
                var existingWord = await wrd.GetWordById(word.Id);

                // If the word doesn't exist, add it to the database
                if (existingWord == null)
                {
                    await wrd.CreateWord(word);
                }
            }

            return Ok();
        }
    }
}
