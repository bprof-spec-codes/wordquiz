using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using WordQuiz.Data.Repositories;
using WordQuiz.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordQuiz.Controllers
{
    [Authorize(Roles = "Player, Admin")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WordStatisticController : ControllerBase
    {

        IWordStaticRepository wrdst;
        IWordRepository wrd;
        ITopicRepository tp;

        private readonly UserManager<Player> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public IWordStaticRepository Wrdst { get => wrdst; set => wrdst = value; }
        public IWordRepository Wrd { get => wrd; set => wrd = value; }
        public ITopicRepository Tp { get => tp; set => tp = value; }

        public UserManager<Player> UserManager => userManager;

        public RoleManager<IdentityRole> RoleManager => roleManager;

        public WordStatisticController(IWordStaticRepository wrdst, IWordRepository wrd, ITopicRepository tp, UserManager<Player> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.wrdst = wrdst;
            this.wrd = wrd;
            this.tp = tp;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        // GET: api/<WordStatisticController>
        [HttpGet]
        public IEnumerable<WordStatistic> Get()
        {
            return wrdst.GetAll();
        }

        // GET api/<WordStatisticController>/5
        [HttpGet("{id}")]
        public WordStatistic? GetWordStatistic(string word)
        {
            return wrdst.GetById(word);
        }

        // POST api/<WordStatisticController>
        [HttpPost]
        public async void AddWordStatistic([FromBody] WordStatistic value)
        {
            wrdst.Add(value);
        }

        // PUT api/<WordStatisticController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditWordStatistic(int id, [FromBody] WordStatistic value)
        {

            wrdst.Update(value);
            return Ok();
        }

        // DELETE api/<WordStatisticController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWordStatistic(string id)
        {
            wrdst.Delete(id);
            return Ok();

        }

        // DELETE api/<WordStatisticController>/5
        [HttpDelete("/all")]
        public async Task<IActionResult> DeleteAllWordStatistic()
        {
            wrdst.DeleteAll();
            return Ok();

        }

        // GET: api/<WordController>
        [HttpGet("{idRandom}")]
        public IEnumerable<Word> GetRandom(int idRandom, string player)
        {
            // Retrieve all words from the database
            var words = wrd.GetAllWords();
            var statistic = wrdst.GetAll();
            List<Word> result = new List<Word>();
            int i = 0;

            var currentPlayerWords = statistic.Where(x => x.Player.PlayerName.Equals(player));

            // Calculate the total weight of all the words

            int totalWeight = currentPlayerWords.Sum(w => w.Score);

            // Generate a random number between 1 and the total weight
            int randomNumber = new Random().Next(1, totalWeight + 1);

            // Iterate over the words and subtract their weight from the random number
            // until the random number is less than or equal to zero
            foreach (var word in words)
            {
                i++;
                if (i < idRandom)
                {
                    randomNumber -= currentPlayerWords.ToArray()[i].Score;
                    if (randomNumber <= 0)
                    {
                        result.Add(word);

                        break;
                    }
                }
                else
                {
                    break;
                }

            }

            return result;
        }

        [HttpGet("{idRandomWithTopic}")]
        public IEnumerable<Word> GetRandomWithTopics(int idRandomWithTopic, string player, List<string> mytopicstitle)
        {
            // Retrieve all words from the database
            var words = wrd.GetAllWords();
            var statistic = wrdst.GetAll();
            List<Word> result = new List<Word>();
            int i = 0;
            var topics = tp.GetAllTopics();
            List<Topic> current_tp = new List<Topic>();

            var currentPlayerWords = statistic.Where(x => x.Player.PlayerName.Equals(player));


            var currentTopics = topics.Where(x => x.Title.Equals(mytopicstitle));

            foreach (var topictitle in mytopicstitle)
            {
                current_tp.Add(tp.GetTopicById(topictitle));
            }

            // Calculate the total weight of all the words

            int totalWeight = currentPlayerWords.Sum(w => w.Score);

            // Generate a random number between 1 and the total weight
            int randomNumber = new Random().Next(1, totalWeight + 1);

            // Iterate over the words and subtract their weight from the random number
            // until the random number is less than or equal to zero
            foreach (var word in words)
            {
                if (mytopicstitle.Contains(word.Topic.Title))
                {
                    i++;
                    if (i < idRandomWithTopic)
                    {
                        randomNumber -= currentPlayerWords.ToArray()[i].Score;
                        if (randomNumber <= 0)
                        {
                            result.Add(word);

                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }


            }

            return result;
        }

    }



}



