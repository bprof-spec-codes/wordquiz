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

            // Select random words from the wordsFromTopics list
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


        /*
            public async Task<ActionResult<IEnumerable<Word>>> StartGame( string[] topicIds, int numberOfWords = 10)
            {



                // Get words from the provided topics
                var wordsFromTopics = new List<Word>();
                foreach (var topicId in topicIds)
                {
                    var words = await wrd.GetWordsByTopicIdAsync(topicId);
                    wordsFromTopics.AddRange(words);
                }

                numberOfWords = Math.Min(numberOfWords, wordsFromTopics.Count);

                // Select random words from the wordsFromTopics list
                var random = new Random();
                var selectedWords = new List<Word>();
                for (int i = 0; i < numberOfWords; i++)
                {
                    int randomIndex = random.Next(0, wordsFromTopics.Count);
                    selectedWords.Add(wordsFromTopics[randomIndex]);
                    wordsFromTopics.RemoveAt(randomIndex);
                }

                return Ok(selectedWords.Select(w => w.Original));
            }






            public async Task<ActionResult<IEnumerable<Word>>> StartGameWeighted( List<string> topicIds, int numberOfWords = 10)
            {

                var player = await userManager.GetUserAsync(User);
                if (player == null)
                {
                    return Unauthorized();
                }

                // Get words from the provided topics
                var wordsFromTopics = new List<Word>();
                foreach (var topicId in topicIds)
                {
                    var words = await wrd.GetWordsByTopicIdAsync(topicId);
                    wordsFromTopics.AddRange(words);
                }

                numberOfWords = Math.Min(numberOfWords, wordsFromTopics.Count);

                // Get word statistics for the current player
                var currentPlayerStats = wrdst.GetAllAsync().Result.Where(x => x.Player.PlayerName.Equals(player));

                // Calculate the total weight of all the words
                int totalWeight = currentPlayerStats.Sum(w => w.Score);

                // Select random words from the wordsFromTopics list based on the weight
                var random = new Random();
                var selectedWords = new List<Word>();
                for (int i = 0; i < numberOfWords; i++)
                {
                    int randomNumber = random.Next(1, totalWeight + 1);
                    int cumulativeWeight = 0;

                    foreach (var word in wordsFromTopics)
                    {
                        var wordStat = currentPlayerStats.FirstOrDefault(ws => ws.Word.Id == word.Id);
                        int wordWeight = wordStat != null ? wordStat.Score : 0;
                        cumulativeWeight += wordWeight;

                        if (randomNumber <= cumulativeWeight)
                        {
                            selectedWords.Add(word);
                            wordsFromTopics.Remove(word);
                            totalWeight -= wordWeight;
                            break;
                        }
                    }
                }

                return Ok(selectedWords.Select(w => w.Original));
            }

           
            public async Task<ActionResult<Dictionary<string, bool>>> EndGame( Dictionary<string, string> guesses)
            {
                Dictionary<string, bool> results = new Dictionary<string, bool>();

                foreach (var guess in guesses)
                {
                    var word = await wrd.GetWordById(guess.Key);
                    if (word != null)
                    {
                        results.Add(guess.Key, word.Translation.Equals(guess.Value, StringComparison.OrdinalIgnoreCase));

                        // Update the word statistics
                        var wordStatistic = await wrdst.GetByIdAsync(guess.Key);
                        if (wordStatistic != null)
                        {
                            wordStatistic.Score = results[guess.Key] ? wordStatistic.Score + 1 : wordStatistic.Score - 1;
                            await wrdst.UpdateAsync(wordStatistic);
                        }
                    }
                }

                return Ok(results);
            }*/

    }


}
