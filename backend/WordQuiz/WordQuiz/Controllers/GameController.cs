using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WordQuiz.Data.Repositories;
using WordQuiz.Models;
using WordQuiz.Logics;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace WordQuiz.Controllers
{
    [Authorize(Roles = "Player, Admin")]
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
            List<Word> words = (List<Word>)wordRepository.GetAllWords();
            
            var distinctWords = words.GroupBy(w => w.Original).Select(g => g.First()).ToList();

            numberOfWords = Math.Min(numberOfWords, distinctWords.Count);

            var random = new Random();
            var selectedWords = new List<Word>();
            for (int i = 0; i < numberOfWords; i++)
            {
                int randomIndex = random.Next(0, words.Count);
                selectedWords.Add(words[randomIndex]);
                words.RemoveAt(randomIndex);
            }

            return Ok(selectedWords.Select(w => w.Original));
        }

        // POST: api/<GameController>/StartGame
        [Authorize]
        [HttpPost("StartGameNoUserWithTopic")]
        public async Task<ActionResult<IEnumerable<Word>>> StartGame([FromBody] string[] topicIds, int numberOfWords = 10)
        {
            var wordsFromTopics = new List<Word>();
            foreach (var topicId in topicIds)
            {
                var words = wordRepository.GetWordsByTopicId(topicId);
                wordsFromTopics.AddRange(words);
            }

            var distinctWords = wordsFromTopics.GroupBy(w => w.Original).Select(g => g.First()).ToList();

            numberOfWords = Math.Min(numberOfWords, distinctWords.Count);

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
        public async Task<ActionResult<IEnumerable<Word>>> StartGameWeighted([FromBody] List<string> topicIds, int numberOfWords)
        {
            if (numberOfWords == 0 || numberOfWords == null)
            {
                numberOfWords = 10;
            }

            Player player = await userManager.GetUserAsync(User);

            var wordsFromTopics = new List<Word>();
            foreach (var topicId in topicIds)
            {
                var words = wordRepository.GetWordsByTopicId(topicId);
                wordsFromTopics.AddRange(words);
            }

            var distinctWords = wordsFromTopics.GroupBy(w => w.Original).Select(g => g.First()).ToList();

            numberOfWords = Math.Min(numberOfWords, distinctWords.Count);

            List<WordStatistic> currentPlayerStats = wordStatRepository.GetAll().Where(x => x.Player.PlayerName.Equals(player)).ToList();

            double totalWeight = 0;
            foreach (var word in distinctWords)
            {
                WordStatistic wordStat = currentPlayerStats.FirstOrDefault(ws => ws.Word.Id == word.Id);
                int wordWeight = wordStat != null ? wordStat.Score : 0;
                totalWeight += 1.0 / (1 + Math.Abs(wordWeight));
            }

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

        // POST: api/<GameController>/end
        [HttpPost("EndGame")]
        public IEnumerable<Result> EndGame(List<GuessInput> guesses)
        {
            string playerid = userManager.GetUserId(User);
            Player player = playerRepository.GetPlayerById(playerid);

            List<Result> results = new List<Result> { };

            List<WordStatistic> currentPlayerStats = new List<WordStatistic>();


            if (player != null)
            {
                currentPlayerStats = wordStatRepository.GetAll().Where(x => x.Player.PlayerName.Equals(player.PlayerName)).ToList();
            }

            foreach (var guess in guesses)
            {
                List<Word> words = wordRepository.GetAllWordsByOriginal(guess.Original);

                if (words != null)
                {
                    Result r = new Result();
                    r.original = guess.Original;
                    r.guess = guess.Guess;
                    List<Word> cwords = words.Where(x => x.Translation.ToUpper().Equals(guess.Guess.ToUpper())).ToList();
                    if (cwords == null || cwords.Count == 0)
                    {
                        r.correct = false;
                    }
                    else
                    {
                        r.correct = true;
                    }

                    r.translations = new List<string>();

                    List<Word> twords = wordRepository.GetAllWordsByOriginal(r.original);

                    foreach (var w in twords)
                    {
                        r.translations.Add(w.Translation);
                    }

                    results.Add(r);

                    WordStatistic wordStatistic = new WordStatistic();

                    if (currentPlayerStats != null && currentPlayerStats.Count > 0)
                    {
                        wordStatistic = currentPlayerStats.FirstOrDefault(ws => ws.WordId == wordRepository.GetWordByOriginal(r.original).Id);
                    }

                    if (wordStatistic != null && wordStatistic.Player != null)
                    {
                        wordStatistic.Score = r.correct ? wordStatistic.Score + 1 : wordStatistic.Score - 1;
                        wordStatRepository.Update(wordStatistic);
                    }
                    else
                    {
                        foreach (var w in words)
                        {
                            WordStatistic nwst = new WordStatistic();
                            nwst.PlayerId = playerid;
                            nwst.WordId = w.Id;
                            nwst.Word = w;
                            nwst.Player = player;
                            nwst.Score = r.correct ? 1 : -1;
                            wordStatRepository.Add(nwst);
                        }
                    }

                }
            }
            return results;
        }
    }
}
