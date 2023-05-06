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

                // Import the topics into the database
                foreach (var topic in topics)
                {
                    // Check if the topic already exists
                    var existingTopic = topicRepository.GetTopicByName(topic.Title);
                    if (existingTopic == null)
                    {
                        topicRepository.AddTopic(topic);
                    }
                }

               // await topicRepository.sa();
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
        {/*
            try
            {
                var topics = topicRepository.GetAllTopics();
                string jsonString = JsonConvert.SerializeObject(topics, Formatting.Indented);

                var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                return File(stream, "application/octet-stream", "topics.json");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error exporting topics: {ex.Message}");
            }*/
            var topics = topicRepository.GetAllTopics();
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = System.Text.Json.JsonSerializer.Serialize(topics, options);

            return Ok(jsonString);
        }




        // POST api/data/import/{dataType}
        [HttpPost("import/{dataType}")]
        public async Task<IActionResult> ImportData(string dataType, [FromForm] IFormFile file)
        {
            using var streamReader = new StreamReader(file.OpenReadStream());
            var jsonString = await streamReader.ReadToEndAsync();

            switch (dataType.ToLower())
            {
                case "words":
                    var words = JsonConvert.DeserializeObject<List<Word>>(jsonString);
                   wordRepository.AddRange(words);
                    break;
                case "users":
                    var users = JsonConvert.DeserializeObject<List<Player>>(jsonString);
                    playerRepository.AddRange(users);
                    break;
                case "wordstatistics":
                    var wordStatistics = JsonConvert.DeserializeObject<List<WordStatistic>>(jsonString);
                    wordStatRepository.AddRange(wordStatistics);
                    break;
                default:
                    return BadRequest("Invalid data type specified.");
            }


            return Ok();
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


            //    var words = await wrd.GetAllWords();
            //    var options = new JsonSerializerOptions { WriteIndented = true };
            //    var jsonString = System.Text.Json.JsonSerializer.Serialize(words, options);

            //    return Ok(jsonString);

            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = System.Text.Json.JsonSerializer.Serialize(data, options);
            //var jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
            var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(jsonString));

            return File(stream, "application/octet-stream", $"{dataType}_export.json");
        }

    }
}
