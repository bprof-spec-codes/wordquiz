using WordQuiz.Data;
using WordQuiz.Data.Repositories;
using WordQuiz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.SignalR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordQuiz.Controllers
{

  //  [Authorize(Roles = "Player, Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        IPlayerRepository player;       

        private readonly UserManager<Player> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public PlayerController(IPlayerRepository player, UserManager<Player> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.player = player;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IPlayerRepository Player { get => player; set => player = value; }

        public UserManager<Player> UserManager => userManager;

        public RoleManager<IdentityRole> RoleManager => roleManager;




        // GET: api/<PlayerController>
        [HttpGet]
        public IEnumerable<Player> GetAllPlayer()
        {
            return player.GetAllPlayers().Result;
        }

        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public Player? GetPlayer(string id)
        {
            return player.GetPlayerById(id).Result;
        }

        // POST api/<PlayerController>
        [HttpPost]
        public async void AddPlayer([FromBody] Player value)
        {
           await player.CreatePlayer(value);

        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditPlayer(int id, [FromBody] Player value)
        {
           await player.UpdatePlayer(value);
            return Ok();
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(string id)
        {
          await player.DeletePlayer(id);
            return Ok();
        }
    }
}
