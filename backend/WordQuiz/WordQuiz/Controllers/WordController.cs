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
    public class WordController : ControllerBase
    {

        
        IWordRepository wrd;
        

        private readonly UserManager<Player> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public WordController(IWordRepository wrd, UserManager<Player> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.wrd = wrd;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IWordRepository Wrd { get => wrd; set => wrd = value; }

        public UserManager<Player> UserManager => userManager;

        public RoleManager<IdentityRole> RoleManager => roleManager;


        // GET: api/<WordController>
        [HttpGet]
        public IEnumerable<Word> Get()
        {
            return wrd.GetAllWords().Result;
        }

        // GET api/<WordController>/5
        [HttpGet("{id}")]
        public Word Get(string id)
        {
            return wrd.GetWordById(id).Result;
        }

        // POST api/<WordController>
        [HttpPost]
        public void Post([FromBody] Word value)
        {

            wrd.CreateWord(value);
        }

        // PUT api/<WordController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Word value)
        {

            wrd.UpdateWord(value);
        }

        // DELETE api/<WordController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            wrd.DeleteWord(id);

        }
    }
}
