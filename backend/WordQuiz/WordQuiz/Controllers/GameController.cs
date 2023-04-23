using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WordQuiz.Data.Repositories;
using WordQuiz.Models;
using WordQuiz.Logics;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json.Linq;

namespace WordQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        IWordRepository wordRepository;
        IWordStaticRepository wordStatRepository;
        IPlayerRepository playerRepository;
        GameLogic gameLogic;


        private readonly UserManager<Player> userManager;

        public GameController(IWordRepository wrd, IWordStaticRepository wrdst, UserManager<Player> userManager, IPlayerRepository playerRepository)
        {
            this.wordRepository = wrd;
            this.wordStatRepository = wrdst;
            this.userManager = userManager;
            this.gameLogic = new GameLogic();
            this.playerRepository = playerRepository;
        }

        // POST: api/<GameController>/StartGame
        [HttpPost("StartGameNoUserNoTopic")]
        public async Task<ActionResult<IEnumerable<Word>>> StartGameNoTopic(int numberOfWords = 10)
        {
            List<Word> words = (List<Word>) wordRepository.GetAllWords();


       

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
                var words =  wordRepository.GetWordsByTopicId(topicId);
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

        //[Authorize]
        [HttpPost("StartGameWeighted")]
        public async Task<ActionResult<IEnumerable<Word>>> StartGameWeighted([FromBody] List<string> topicIds, int numberOfWords = 2)
        {
            if (numberOfWords ==0 || numberOfWords==null )
            {
                numberOfWords = 2;
            }

            Player player = await userManager.GetUserAsync(User);

            // Get words from the provided topics
            var wordsFromTopics = new List<Word>();
            foreach (var topicId in topicIds)
            {
                var words =  wordRepository.GetWordsByTopicId(topicId);
                wordsFromTopics.AddRange(words);
            }

            // Group words by their Original property and select one word from each group
            var distinctWords = wordsFromTopics.GroupBy(w => w.Original).Select(g => g.First()).ToList();

            numberOfWords = Math.Min(numberOfWords, distinctWords.Count);


            // Get word statistics for the current player
            List<WordStatistic> currentPlayerStats = wordStatRepository.GetAll().Where(x => x.Player.PlayerName.Equals(player)).ToList();

            // Calculate the total weight of all the words based on the inverse of their scores
            double totalWeight = 0;
            foreach (var word in distinctWords)
            {
                WordStatistic wordStat = currentPlayerStats.FirstOrDefault(ws => ws.Word.Id == word.Id);
                int wordWeight = wordStat != null ? wordStat.Score : 0;
                totalWeight += 1.0 / (1 + Math.Abs(wordWeight));
            }

            // Select random words from the distinctWords list based on the weight
            Random random = new Random();
            List<Word> selectedWords = new List<Word>();
            for (int i = 0; i < numberOfWords; i++)
            {
                double randomNumber = random.NextDouble() * totalWeight;
                double cumulativeWeight = 0;

                Word selectedWord = null;
                foreach (var word in distinctWords)
                {
                    WordStatistic wordStat = currentPlayerStats.FirstOrDefault(ws => ws.Word.Id == word.Id);
                    int wordWeight = wordStat != null ? wordStat.Score : 0;
                    cumulativeWeight += 1.0 / (1 + Math.Abs(wordWeight));

                    if (randomNumber <= cumulativeWeight)
                    {
                        selectedWord = word;
                        break;
                    }
                }

                if (selectedWord != null)
                {
                    selectedWords.Add(selectedWord);
                    distinctWords.Remove(selectedWord);
                    WordStatistic selectedWordStat = currentPlayerStats.FirstOrDefault(ws => ws.Word.Id == selectedWord.Id);
                    int selectedWordWeight = selectedWordStat != null ? selectedWordStat.Score : 0;
                    totalWeight -= 1.0 / (1 + Math.Abs(selectedWordWeight));
                }
            }

            return Ok(selectedWords.Select(w => w.Original));

        }
        /*
        // POST: api/<GameController>/end
        [HttpPost("EndGame")]
        public  IEnumerable<Result> EndGame( Dictionary<string, string> guesses)
        {
            string playerid =  userManager.GetUserId(User);
            Player player = playerRepository.GetPlayerById(playerid);

            List<Result> results = new List<Result> { };

            List<WordStatistic> currentPlayerStats = new List<WordStatistic>();
            WordStatistic wordStatistic = new WordStatistic();

            if (player!=null)
            {
                // Get word statistics for the current player
                 currentPlayerStats = wordStatRepository.GetAll().Where(x => x.Player.PlayerName.Equals(player)).ToList();
            }
           


            foreach (var guess in guesses)
            {
                var word =  wordRepository.GetWordByOriginal(guess.Key);
                if (word != null)
                {
                    Result r = new Result();
                    r.original = guess.Key;
                    r.guess = guess.Value;
                    r.correct = word.Translation.Equals(guess.Value, StringComparison.OrdinalIgnoreCase);

                    r.translations = new List<string>();


                    List<Word> twords = wordRepository.GetAllWordsByOriginal(r.original);

                    foreach (var w in twords)
                    {

                        r.translations.Add(w.Translation);


                    }

                    results.Add(r);




                    if (currentPlayerStats!=null)
                    {
                        // Update the word statistics
                         wordStatistic = currentPlayerStats.FirstOrDefault(ws => ws.Word.Original == r.original);
                    }
              
                    if (wordStatistic != null)
                    {
                        

                        wordStatistic.Score = r.correct ? wordStatistic.Score + 1 : wordStatistic.Score - 1;
                         wordStatRepository.Update(wordStatistic);
                    }
                }
            }

            // Convert the dictionary to a JSON object
           // JObject resultJson = JObject.FromObject(results);

            return results;
        }
        */
        // POST: api/<GameController>/end
        // POST: api/<GameController>/end
        [HttpPost("EndGame")]
        public IEnumerable<Result> EndGame(List<GuessInput> guesses)
        { 
            string playerid = userManager.GetUserId(User);
            Player player = playerRepository.GetPlayerById(playerid);

            List<Result> results = new List<Result> { };

            List<WordStatistic> currentPlayerStats = new List<WordStatistic>();
            WordStatistic wordStatistic = new WordStatistic();

            if (player != null)
            {
                // Get word statistics for the current player
                currentPlayerStats = wordStatRepository.GetAll().Where(x => x.Player.PlayerName.Equals(player)).ToList();
            }



            foreach (var guess in guesses)
            {
                var word = wordRepository.GetWordByOriginal(guess.Original);
                if (word != null)
                {
                    Result r = new Result();
                    r.original = guess.Original;
                    r.guess = guess.Guess;
                    r.correct = word.Translation.Equals(guess.Guess, StringComparison.OrdinalIgnoreCase);

                    r.translations = new List<string>();


                    List<Word> twords = wordRepository.GetAllWordsByOriginal(r.original);

                    foreach (var w in twords)
                    {

                        r.translations.Add(w.Translation);


                    }

                    results.Add(r);




                    if (currentPlayerStats != null)
                    {
                        // Update the word statistics
                        wordStatistic = currentPlayerStats.FirstOrDefault(ws => ws.Word.Original == r.original);
                    }

                    if (wordStatistic != null)
                    {


                        wordStatistic.Score = r.correct ? wordStatistic.Score + 1 : wordStatistic.Score - 1;
                        wordStatRepository.Update(wordStatistic);
                    }
                }
            }

            // Convert the dictionary to a JSON object
            // JObject resultJson = JObject.FromObject(results);

            return results;
        }
        

        // POST: api/<GameController>/end
        [HttpPost("endWordString")]
        public async Task<ActionResult<Dictionary<string, bool>>> EndGameNoPlayer([FromBody] Dictionary<Word, string> guesses)
        {
            List<Result> results = new List<Result> { };

            foreach (var guess in guesses)
            {
                var word =  wordRepository.GetWordByOriginal(guess.Key.Original);
                if (word != null)
                {
                    Result r = new Result();
                    r.original = guess.Key.Original;
                    r.guess = guess.Value;
                    r.correct = word.Translation.Equals(guess.Value, StringComparison.OrdinalIgnoreCase);




                    List<Word> twords = wordRepository.GetAllWordsByOriginal(r.original);

                    foreach (var w in twords)
                    {

                        r.translations.Add(w.Translation);


                    }

                    results.Add(r);


                    // Update the word statistics
                    var wordStatistic =  wordStatRepository.GetById(guess.Key.Original);
                    if (wordStatistic != null)
                    {
                        wordStatistic.Score = r.correct ? wordStatistic.Score + 1 : wordStatistic.Score - 1;
                         wordStatRepository.Update(wordStatistic);
                    }
                }
            }

           

            // Convert the dictionary to a JSON object
            JObject resultJson = JObject.FromObject(results);

            return Ok(resultJson);
        }


    }
}
