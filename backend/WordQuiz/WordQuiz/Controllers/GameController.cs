using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WordQuiz.Data.Repositories;
using WordQuiz.Models;
using WordQuiz.Logics;

namespace WordQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        IWordRepository wordRepository;
        IWordStaticRepository wordStatRepository;
        GameLogic gameLogic;


        private readonly UserManager<Player> userManager;

        public GameController(IWordRepository wrd, IWordStaticRepository wrdst, UserManager<Player> userManager)
        {
            this.wordRepository = wrd;
            this.wordStatRepository = wrdst;
            this.userManager = userManager;
            this.gameLogic = new GameLogic();
        }

        // POST: api/<GameController>/StartGame
        [HttpPost("StartGameNoUserNoTopic")]
        public async Task<ActionResult<IEnumerable<Word>>> StartGameNoTopic(int numberOfWords = 10)
        {
            List<Word> words = (List<Word>)await wordRepository.GetAllWords();

            // Group words by their Original property and select one word from each group
            var distinctWords = words.GroupBy(w => w.Original).Select(g => g.First()).ToList();

            numberOfWords = Math.Min(numberOfWords, distinctWords.Count);

            // Select random words from the wordsFromTopics list
            var random = new Random();
            var selectedWords = new List<Word>();
            for (int i = 0; i < numberOfWords; i++)
            {
                int randomIndex = random.Next(0, words.Count);
                selectedWords.Add(words[randomIndex]);
                words.RemoveAt(randomIndex);
            }

            return Ok(selectedWords.Select(w => w.Original));

            /*
            List<Word> selected = await gameLogic.selectedWordsNotopicAsync(wrd, numberOfWords);

            // return Ok(await gameLogic.selectedWordsNotopicAsync(wrd));

            return Ok(selected);*/
        }



        // POST: api/<GameController>/StartGame
        [HttpPost("StartGameNoUserWithTopic")]
        public async Task<ActionResult<IEnumerable<Word>>> StartGame([FromBody] string[] topicIds, int numberOfWords = 10)
        {
            // Get words from the provided topics
            var wordsFromTopics = new List<Word>();
            foreach (var topicId in topicIds)
            {
                var words = await wordRepository.GetWordsByTopicIdAsync(topicId);
                wordsFromTopics.AddRange(words);
            }

            // Group words by their Original property and select one word from each group
            var distinctWords = wordsFromTopics.GroupBy(w => w.Original).Select(g => g.First()).ToList();

            numberOfWords = Math.Min(numberOfWords, distinctWords.Count);


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

        [Authorize]
        [HttpPost("StartGameWeighted")]
        public async Task<ActionResult<IEnumerable<Word>>> StartGameWeighted([FromBody] List<string> topicIds, int numberOfWords = 10)
        {
            Player player = await userManager.GetUserAsync(User);

            // Get words from the provided topics
            var wordsFromTopics = new List<Word>();
            foreach (var topicId in topicIds)
            {
                var words = await wordRepository.GetWordsByTopicIdAsync(topicId);
                wordsFromTopics.AddRange(words);
            }

            // Group words by their Original property and select one word from each group
            var distinctWords = wordsFromTopics.GroupBy(w => w.Original).Select(g => g.First()).ToList();

            numberOfWords = Math.Min(numberOfWords, distinctWords.Count);


            // Get word statistics for the current player
            var currentPlayerStats = wordStatRepository.GetAllAsync().Result.Where(x => x.Player.PlayerName.Equals(player));

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

        // POST: api/<GameController>/end
        [HttpPost("end")]
        public async Task<ActionResult<Dictionary<string, bool>>> EndGame([FromBody] Dictionary<string, string> guesses)
        {
            Dictionary<string, bool> results = new Dictionary<string, bool>();

            foreach (var guess in guesses)
            {
                var word = await wordRepository.GetWordById(guess.Key);
                if (word != null)
                {
                    results.Add(guess.Key, word.Translation.Equals(guess.Value, StringComparison.OrdinalIgnoreCase));

                    // Update the word statistics
                    var wordStatistic = await wordStatRepository.GetByIdAsync(guess.Key);
                    if (wordStatistic != null)
                    {
                        wordStatistic.Score = results[guess.Key] ? wordStatistic.Score + 1 : wordStatistic.Score - 1;
                        await wordStatRepository.UpdateAsync(wordStatistic);
                    }
                }
            }

            return Ok(results);
        }
    }
}
