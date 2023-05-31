using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WordQuiz.Models
{
    public class WordStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string PlayerId { get; set; }
        public string WordId { get; set; }
        public int Score { get; set; }


        [NotMapped]
        public Player Player { get; set; }

        [NotMapped]
        public Word Word { get; set; }

        public WordStatistic()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
