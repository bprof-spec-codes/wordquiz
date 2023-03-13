using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WordQuiz.Data.Repositories;
using WordQuiz.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordQuiz.Controllers
{
    [Authorize(Roles = "Player, Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class WordStatisticController : ControllerBase
    {
        IPlayerRepository player;
        ITopicRepository tp;
        IWordRepository wrd;
        IWordStaticRepository wrdst;

        private readonly UserManager<Player> userManager;
        private readonly RoleManager<IdentityRole> roleManager;


        // GET: api/<WordStatisticController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WordStatisticController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WordStatisticController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WordStatisticController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WordStatisticController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
