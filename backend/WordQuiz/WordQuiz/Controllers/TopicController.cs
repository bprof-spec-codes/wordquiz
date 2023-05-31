using WordQuiz.Data;
using WordQuiz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.SignalR;
using WordQuiz.Data.Repositories;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordQuiz.Controllers
{
    //[Authorize(Roles = "Player, Admin")]
    [Route("api/[controller]")]
    [ApiController]
    //  [Authorize]
    public class TopicController : ControllerBase
    {
        ITopicRepository tp;

        private readonly UserManager<Player> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public TopicController(ITopicRepository tp, UserManager<Player> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.tp = tp;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public ITopicRepository Tp { get => tp; set => tp = value; }

        public UserManager<Player> UserManager => userManager;

        public RoleManager<IdentityRole> RoleManager => roleManager;

        [AllowAnonymous]
        // GET: api/<TopicController>
        [HttpGet]
        public IEnumerable<Topic> GetAllTopic()
        {
            return tp.GetAllTopics();
        }

        [AllowAnonymous]
        // GET api/<TopicController>/5
        [HttpGet("{id}")]
        public Topic? GetTopic(string id)
        {
            return tp.GetTopicById(id);
        }

        // POST api/<TopicController>
        [Authorize]
        [HttpPost]
        public IActionResult AddTopic([FromBody] Topic value)
        {
            return Ok(tp.AddTopic(value));
        }

        // PUT api/<TopicController>/5
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult EditTopic(int id, [FromBody] Topic value)
        {
            tp.UpdateTopic(value);
            return Ok();
        }

        // DELETE api/<TopicController>/5
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeleteTopic(string id)
        {
            tp.DeleteTopic(id);
            return Ok();
        }


        // GET api/<WordController>/ExportWords
        [HttpGet("ExportTopics")]
        public ActionResult Exporttopics()
        {
            var topics = tp.GetAllTopics();
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = System.Text.Json.JsonSerializer.Serialize(topics, options);

            return Ok(jsonString);
        }
    }
}
