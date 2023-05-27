
using System.Collections.Generic;
using WordQuiz.Models;

namespace WordQuiz.Models
{
    public class PlayerStatistics
    {
        public string PlayerId { get; set; }
        public List<WordStatistic> WordStatistics { get; set; }

        public PlayerStatistics()
        {
            WordStatistics = new List<WordStatistic>();
        }
    }
}
