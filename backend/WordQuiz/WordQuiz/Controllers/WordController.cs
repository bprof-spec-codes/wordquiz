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

        // GET: api/<WordController>
        [HttpGet("Random/{idRandom}")]
        public async Task<IEnumerable<Word>> GetRandom(int idRandom)
        {
            var user = await userManager.GetUserAsync(User);

            var words = wrd.GetAllWords();
            var statistic = wrdst.GetAll();
            List<Word> result = new List<Word>();
            int i = 0;

            var currentPlayerWords = statistic.Where(x => x.PlayerId == user.Id);

            return result;
        }

        [HttpGet("RandomWithTopics/{idRandomWithTopic}")]
        public async Task<IEnumerable<Word>> GetRandomWithTopics(int idRandomWithTopic, [FromQuery] List<string> mytopicstitle)
        {
            var user = await userManager.GetUserAsync(User);

            var words = wrd.GetAllWords();
            var statistic = wrdst.GetAll();
            List<Word> result = new List<Word>();
            int i = 0;
            var topics = tp.GetAllTopics();
            List<Topic> current_tp = new List<Topic>();

            var currentPlayerWords = statistic.Where(x => x.PlayerId == user.Id);

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
                var existingTopic = tp.GetTopicById(word.TopicId);

                if (existingTopic == null)
                {
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

                word.Topic = existingTopic;

                var existingWord = wrd.GetWordById(word.Id);

                if (existingWord == null)
                {
                    wrd.CreateWord(word);
                }
            }
            return Ok();
        }
    }
}
