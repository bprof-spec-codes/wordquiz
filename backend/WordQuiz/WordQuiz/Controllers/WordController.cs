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
    [Authorize(Roles = "Player, Admin")]
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


        // GET: api/<WordController>
        [HttpGet("Random/{idRandom}")]
        public async Task<IEnumerable<Word>> GetRandom(int idRandom)
        {
            // Retrieve the authenticated user
            var user = await userManager.GetUserAsync(User);

            // Retrieve all words from the database
            var words =  wrd.GetAllWords();
            var statistic =  wrdst.GetAll();
            List<Word> result = new List<Word>();
            int i = 0;

            var currentPlayerWords = statistic.Where(x => x.PlayerId == user.Id);

            // ...

            return result;
        }

        [HttpGet("RandomWithTopics/{idRandomWithTopic}")]
        public async Task<IEnumerable<Word>> GetRandomWithTopics(int idRandomWithTopic, [FromQuery] List<string> mytopicstitle)
        {
            // Retrieve the authenticated user
            var user = await userManager.GetUserAsync(User);

            // Retrieve all words from the database
            var words =  wrd.GetAllWords();
            var statistic =  wrdst.GetAll();
            List<Word> result = new List<Word>();
            int i = 0;
            var topics = tp.GetAllTopics();
            List<Topic> current_tp = new List<Topic>();

            var currentPlayerWords = statistic.Where(x => x.PlayerId == user.Id);

            // ...

            return result;
        }



        // POST api/<WordController>
        [HttpPost]
        public async void AddWord([FromBody] Word value)
        {

             wrd.CreateWord(value);
        }

        // PUT api/<WordController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditWord(int id, [FromBody] Word value)
        {

             wrd.UpdateWord(value);
            return Ok();
        }

        // DELETE api/<WordController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWord(string id)
        {
             wrd.DeleteWord(id);
            return Ok();

        }

        // POST api/<WordController>/ImportWords
        [HttpPost("ImportWords")]
        public async Task<IActionResult> ImportWords([FromBody] List<Word> words)
        {
            foreach (var word in words)
            {
                // Check if the topic exists
                var existingTopic = tp.GetTopicById(word.TopicId);

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

                        tp.AddTopic(newTopic);
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
                var existingWord =  wrd.GetWordById(word.Id);

                // If the word doesn't exist, add it to the database
                if (existingWord == null)
                {
                     wrd.CreateWord(word);
                }
            }

            return Ok();
        }




    }
}
