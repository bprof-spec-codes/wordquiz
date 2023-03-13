using WordQuiz.Data;
using WordQuiz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.SignalR;
using WordQuiz.Data.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordQuiz.Controllers
{
    [Authorize(Roles = "Player, Admin")]
    [Route("api/[controller]")]
    [ApiController]
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




        // GET: api/<TopicController>
        [HttpGet]
        public IEnumerable<Topic> Get()
        {
            return tp.GetAllTopics();
        }

        // GET api/<TopicController>/5
        [HttpGet("{id}")]
        public Topic Get(string id)
        {
            return tp.GetTopicById(id);
        }

        // POST api/<TopicController>
        [HttpPost]
        public void Post([FromBody] Topic value)
        {
            tp.AddTopic(value);
        }

        // PUT api/<TopicController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Topic value)
        {
            tp.UpdateTopic(value);
        }

        // DELETE api/<TopicController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            tp.DeleteTopic(id);
        }
    }
}
