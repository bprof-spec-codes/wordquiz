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
    [Authorize]
    public class PlayerController : ControllerBase
    {

        IPlayerRepository playerRepository;       

        private readonly UserManager<Player> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public PlayerController(IPlayerRepository playerRepository, UserManager<Player> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.playerRepository = playerRepository;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public IPlayerRepository Player { get => playerRepository; set => playerRepository = value; }

        public UserManager<Player> UserManager => userManager;

        public RoleManager<IdentityRole> RoleManager => roleManager;

        // GET: api/<PlayerController>/all
        [HttpGet("all")]
        public IEnumerable<Player> GetAllPlayers()
        {
            return playerRepository.GetAllPlayers().Result;
        }

        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public async Task<object> GetPlayer(string id = null)
        {
            
            Player p = playerRepository.GetPlayerById(id).Result;
            return new {
                email = p.Email,
                id = p.Id,
                playerName = p.PlayerName,
                userName = p.UserName,
                admin = await this.userManager.IsInRoleAsync(p, "Admin")
            };
        }

        // GET api/<PlayerController>
        [HttpGet]
        [Authorize]
        public async Task<object> GetPlayer()
        {
            // FIXME cannot get user from userManager.GetUserAsync(User)
            string id = this.userManager.GetUserId(User);
            Player p = (await this.playerRepository.GetAllPlayers()).First(p => p.Email == id);
            return new
            {
                email = p.Email,
                id = p.Id,
                playerName = p.PlayerName,
                userName = p.UserName,
                admin = await this.userManager.IsInRoleAsync(p, "Admin")
            };
        }



        // POST api/<PlayerController>
        [HttpPost]
        public async void AddPlayer([FromBody] Player value)
        {
           await playerRepository.CreatePlayer(value);

        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditPlayer(int id, [FromBody] Player value)
        {
           await playerRepository.UpdatePlayer(value);
            return Ok();
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(string id)
        {
          await playerRepository.DeletePlayer(id);
            return Ok();
        }
    }
}
