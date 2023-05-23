using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WordQuiz.Data.Repositories;
using WordQuiz.Models;
using WordQuiz.Logics;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace WordQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IWordRepository wordRepository;
        private readonly IWordStaticRepository wordStatRepository;
        private readonly IPlayerRepository playerRepository;
        private readonly GameLogic gameLogic;
        private readonly UserManager<Player> userManager;

        public GameController(IWordRepository wrd, IWordStaticRepository wrdst, UserManager<Player> userManager, IPlayerRepository playerRepository)
        {
            wordRepository = wrd;
            wordStatRepository = wrdst;
            this.userManager = userManager;
            gameLogic = new GameLogic();
            this.playerRepository = playerRepository;
        }

        [HttpPost("StartGameNoTopic")]
        public async Task<ActionResult<IEnumerable<string>>> StartGameNoTopic(int numberOfWords = 10)
        {
            List<Word> words = await wordRepository.GetAllWordsAsync();

            var selectedWords = gameLogic.SelectWordsWithoutTopic(words, numberOfWords);

            return Ok(selectedWords.Select(w => w.Original));
        }