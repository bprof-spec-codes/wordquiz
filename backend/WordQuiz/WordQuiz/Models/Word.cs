using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WordQuiz.Models
{
    public class Word
    {
        [Key]

        public string Id { get; set; }
        [Required]
        public string Original { get; set; }
        [Required]
        public string Translation { get; set; }

        /*
        [Required]
        public List<string> Translation { get; set;}*/

        [Required]
        [ForeignKey(nameof(Topic))]
        public string TopicId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public Topic Topic { get; set; }

        public Word()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
