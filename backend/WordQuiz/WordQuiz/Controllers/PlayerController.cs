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

    [Authorize(Roles = "Player, Admin")]
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
        public async Task<IEnumerable<PlayerInfoViewModel>> GetAllPlayers()
        {
            var players = playerRepository.GetAllPlayers();

            var playerInfos = new List<PlayerInfoViewModel>();
            foreach (var player in players)
            {
                playerInfos.Add(new PlayerInfoViewModel
                {
                    Id = player.Id,
                    Email = player.Email,
                    PlayerName = player.PlayerName,
                    UserName = player.UserName,
                    IsAdmin = await userManager.IsInRoleAsync(player, "Admin")
                });
            }

            return playerInfos;
        }


        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public async Task<object> GetPlayer(string id)
        {
            Player p = playerRepository.GetPlayerById(id);
            return new
            {
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
            Player p = (await userManager.GetUserAsync(User));
            return new
            {
                email = p.Email,
                id = p.Id,
                playerName = p.PlayerName,
                userName = p.UserName,
                admin = await this.userManager.IsInRoleAsync(p, "Admin")
            };
        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditPlayer(int id, [FromBody] Player value)
        {
            playerRepository.UpdatePlayer(value);
            return Ok();
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(string id)
        {
            playerRepository.DeletePlayer(id);
            return Ok();
        }
    }
}
