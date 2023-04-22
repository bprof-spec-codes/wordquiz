using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WordQuiz.Models
{
    public class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [NotMapped]
        [ValidateNever]
        [JsonIgnore]
        public List<Word> Words { get; set; }

        public Topic()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
