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
        
        IWordStaticRepository wrdst;

        private readonly UserManager<Player> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public WordStatisticController(IWordStaticRepository wrdst, UserManager<Player> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.wrdst = wrdst;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IWordStaticRepository Wrdst { get => wrdst; set => wrdst = value; }

        public UserManager<Player> UserManager => userManager;

        public RoleManager<IdentityRole> RoleManager => roleManager;


        // GET: api/<WordStatisticController>
        [HttpGet]
        public IEnumerable<WordStatistic> Get()
        {
            return wrdst.GetAllAsync().Result;
        }

        // GET api/<WordStatisticController>/5
        [HttpGet("{id}")]
        public WordStatistic Get(string word)
        {
            return wrdst.GetByIdAsync(word).Result;
        }

        // POST api/<WordStatisticController>
        [HttpPost]
        public void Post([FromBody] WordStatistic value)
        {
            wrdst.AddAsync(value);
        }

        // PUT api/<WordStatisticController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WordStatistic value)
        {

            wrdst.AddAsync(value);
        }

        // DELETE api/<WordStatisticController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            wrdst.DeleteAsync(id);

        }
    }
}
