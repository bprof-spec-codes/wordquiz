using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WordQuiz.Data.Repositories;
using WordQuiz.Models;

namespace WordQuiz.Logics
{
    public class GameLogic
    {
        public GameLogic() { }

        public async Task<List<Word>> selectedWordsNotopicAsync(IWordRepository wrd, int numberOfWords = 10)
        {
            List<Word> words = (List<Word>)wrd.GetAllWords();

            numberOfWords = Math.Min(numberOfWords, words.Count);

            var random = new Random();
            List<Word> selectedWords = new List<Word>();
            for (int i = 0; i < numberOfWords; i++)
            {
                int randomIndex = random.Next(0, words.Count);
                selectedWords.Add(words[randomIndex]);
                words.RemoveAt(randomIndex);
            }

            return (List<Word>)selectedWords.Select(w => w.Original);
        }
    }
}

