using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WordQuiz.Models;

namespace WordQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly UserManager<Player> _userManager;

        public AuthController(UserManager<Player> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var claim = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.NameId, user.UserName)
                };
                foreach (var role in await _userManager.GetRolesAsync(user))
                {
                    claim.Add(new Claim(ClaimTypes.Role, role));
                }
                var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("WordQuizSecurityKey"));
                var token = new JwtSecurityToken(
                 issuer: "http://www.security.org", audience: "http://www.security.org",
                 claims: claim, expires: DateTime.Now.AddMinutes(60),
                 signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
                );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }

        [HttpPut]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            var user = new Player
            {
                Email = model.Email,
                UserName = model.UserName,
                SecurityStamp = Guid.NewGuid().ToString(),
                PlayerName = model.PlayerName
                
                //PhotoContentType = model.PhotoContentType,
                //PhotoData = model.PhotoData
            };
            await _userManager.CreateAsync(user, model.Password);
            await _userManager.AddToRoleAsync(user, "Player");
            return Ok();
        }
    }
}
