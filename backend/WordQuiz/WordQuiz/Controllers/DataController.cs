using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.NetworkInformation;
using System.Text;
using WordQuiz.Data.Repositories;
using WordQuiz.Logics;
using WordQuiz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace WordQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        IWordRepository wordRepository;
        IWordStaticRepository wordStatRepository;
        IPlayerRepository playerRepository;
        ITopicRepository topicRepository;

        private readonly UserManager<Player> userManager;

        public DataController(IWordRepository wrd, IWordStaticRepository wrdst, IPlayerRepository playerRepository, ITopicRepository topicRepository)
        {
            this.wordRepository = wrd;
            this.wordStatRepository = wrdst;
            this.userManager = userManager;
            this.playerRepository = playerRepository;
            this.topicRepository = topicRepository;
        }

        // POST api/data/import/topics
        [HttpPost("import/topics")]
        public async Task<IActionResult> ImportTopics([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("File not provided or empty.");
            }

            try
            {
                using var streamReader = new StreamReader(file.OpenReadStream());
                string jsonString = await streamReader.ReadToEndAsync();
                var topics = JsonConvert.DeserializeObject<List<Topic>>(jsonString);

                foreach (var topic in topics)
                {
                    var existingTopic = topicRepository.GetTopicByName(topic.Title);
                    if (existingTopic == null)
                    {
                        topicRepository.AddTopic(topic);
                    }
                }
                return Ok("Topics imported successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error importing topics: {ex.Message}");
            }
        }

        // GET api/data/export/topics
        [HttpGet("export/topics")]
        public async Task<IActionResult> ExportTopics()
        {
            var topics = topicRepository.GetAllTopics();
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = System.Text.Json.JsonSerializer.Serialize(topics, options);

            return Ok(jsonString);
        }


        [HttpPost("import/words")]
        public async Task<IActionResult> ImportWords([FromForm] IFormFile file)
        {
            try
            {
                using var reader = new StreamReader(file.OpenReadStream());
                var jsonString = await reader.ReadToEndAsync();
                var importedWords = JsonConvert.DeserializeObject<IEnumerable<Word>>(jsonString);

                foreach (var word in importedWords)
                {
                    var existingWordT = wordRepository.GetWordByTranslation(word.Translation);
                    var existingWordO = wordRepository.GetWordByOriginal(word.Original);
                    if (existingWordT == null && existingWordO == null)
                    {
                        wordRepository.CreateWord(word);
                    }
                    else
                    {

                    }
                }

                return Ok(new { message = "Words imported successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"An error occurred: {ex.Message}" });
            }
        }

        // GET api/data/export/{dataType}
        [HttpGet("export/{dataType}")]
        public async Task<IActionResult> ExportData(string dataType)
        {
            object data;

            switch (dataType.ToLower())
            {
                case "words":
                    data = wordRepository.GetAllWords();
                    break;
                case "users":
                    data = playerRepository.GetAllPlayers();
                    break;
                case "wordstatistics":
                    data = wordStatRepository.GetAll();
                    break;
                default:
                    return BadRequest("Invalid data type specified.");
            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = System.Text.Json.JsonSerializer.Serialize(data, options);
            var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(jsonString));

            return File(stream, "application/octet-stream", $"{dataType}_export.json");
        }

        // GET api/data/user/wordstatistics
        [HttpGet("user/wordstatistics")]
        [Authorize]
        public async Task<IActionResult> GetUserWordStatistics()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var wordStatistics = wordStatRepository.GetUserWordStatistics(userId);

            return Ok(wordStatistics);
        }
    }
}
