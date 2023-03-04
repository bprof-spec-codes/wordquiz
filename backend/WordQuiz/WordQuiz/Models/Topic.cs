using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WordQuiz.Models
{
    public class Topic
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [NotMapped]
        [ValidateNever]
        public List<Word> Words { get; set; }

        public Topic()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
