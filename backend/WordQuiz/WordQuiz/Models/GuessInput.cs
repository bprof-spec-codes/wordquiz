namespace WordQuiz.Models
{
    public class GuessInput
    {
        public string Original { get; set; }
        public string Guess { get; set; }
        public string WordId { get; set; }  
        public bool IsCorrect { get; set; }  
    }
}
