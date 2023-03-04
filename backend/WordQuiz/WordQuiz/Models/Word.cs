using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required]
        [ForeignKey(nameof(Topic))]
        public string TopicId { get; set; }

        [NotMapped]
        public Topic Topic { get; set; }

        public Word()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
