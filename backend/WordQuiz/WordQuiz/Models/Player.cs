using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace WordQuiz.Models
{
    public class Player : IdentityUser
    {
        public string PlayerName { get; set; }

        [NotMapped]
        [ValidateNever]
        public List<WordStatistic> WordStatistics { get; set; }
    }
}
