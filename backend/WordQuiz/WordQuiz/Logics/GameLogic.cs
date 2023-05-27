using WordQuiz.Data.Repositories;
using WordQuiz.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace WordQuiz.Logics
{
    public class GameLogic
    {
        public List<Word> SelectWordsWithoutTopic(List<Word> words, int numberOfWords)
        {
            var distinctWords = words.GroupBy(w => w.Original).Select(g => g.First()).ToList();

            numberOfWords = Math.Min(numberOfWords, distinctWords.Count);

            var random = new Random();
            var selectedWords = new List<Word>();

            while (selectedWords.Count < numberOfWords)
            {
                var randomIndex = random.Next(distinctWords.Count);
                var word = distinctWords[randomIndex];
                selectedWords.Add(word);
                distinctWords.RemoveAt(randomIndex);
            }

            return selectedWords;
        }

        public async Task<List<Word>> GetWordsFromTopics(IWordRepository wordRepository, string[] topicIds)
        {
            var wordsFromTopics = new List<Word>();

            foreach (var topicId in topicIds)
            {
                var words = await wordRepository.GetWordsByTopicIdAsync(topicId);
                wordsFromTopics.AddRange(words);
            }

            return wordsFromTopics;
        }

        public List<Word> SelectWordsFromTopics(List<Word> wordsFromTopics, int numberOfWords)
        {
            var distinctWords = wordsFromTopics.GroupBy(w => w.Original).Select(g => g.First()).ToList();

            numberOfWords = Math.Min(numberOfWords, distinctWords.Count);

            var random = new Random();
            var selectedWords = new List<Word>();

            while (selectedWords.Count < numberOfWords)
            {
                var randomIndex = random.Next(distinctWords.Count);
                var word = distinctWords[randomIndex];
                selectedWords.Add(word);
                distinctWords.RemoveAt(randomIndex);
            }

            return selectedWords;
        }

        public List<Word> SelectWeightedWords(List<Word> wordsFromTopics, int numberOfWords, PlayerStatistics currentPlayerStats)
        {
            var distinctWords = wordsFromTopics.GroupBy(w => w.Original).Select(g => g.First()).ToList();
            var weightedWords = GetWeightedWords(distinctWords, currentPlayerStats);

            numberOfWords = Math.Min(numberOfWords, weightedWords.Count);

            var random = new Random();
            var selectedWords = new List<Word>();

            while (selectedWords.Count < numberOfWords)
            {
                var randomIndex = random.Next(weightedWords.Count);
                var word = weightedWords[randomIndex];
                selectedWords.Add(word);
                weightedWords.RemoveAt(randomIndex);
            }

            return selectedWords;
        }

        public List<Word> GetWeightedWords(List<Word> words, PlayerStatistics currentPlayerStats)
        {
            var weightedWords = new List<Word>();

            foreach (var word in words)
            {
                var wordStat = currentPlayerStats.WordStatistics.FirstOrDefault(ws => ws.WordId == word.Id);

                if (wordStat != null)
                {
                    var correctGuesses = wordStat.CorrectGuesses;
                    var incorrectGuesses = wordStat.IncorrectGuesses;

                    var weight = CalculateWeight(correctGuesses, incorrectGuesses);
                    for (var i = 0; i < weight; i++)
                    {
                        weightedWords.Add(word);
                    }
                }
            }

            return weightedWords;
        }

        public int CalculateWeight(int correctGuesses, int incorrectGuesses)
        {
            var weight = 1;
            var totalGuesses = correctGuesses + incorrectGuesses;

            if (totalGuesses > 0)
            {
                var successRate = (double)correctGuesses / totalGuesses;
                weight = (int)Math.Ceiling(1 / successRate);
            }

            return weight;
        }

        public async Task UpdatePlayerStatistics(IWordRepository wordRepository, PlayerStatistics currentPlayerStats, List<GuessInput> guesses)
        {
            foreach (var guess in guesses)
            {
                var word = await wordRepository.GetWordByIdAsync(guess.Original);
                if (word == null)
                {
                    continue;
                }

                var wordStat = currentPlayerStats.WordStatistics.FirstOrDefault(ws => ws.WordId == word.Id);
                if (wordStat == null)
                {
                    wordStat = new WordStatistic
                    {
                        WordId = word.Id,
                        CorrectGuesses = 0,
                        IncorrectGuesses = 0
                    };
                    currentPlayerStats.WordStatistics.Add(wordStat);
                }

                if (guess.IsCorrect)
                {
                    wordStat.CorrectGuesses++;
                }
                else
                {
                    wordStat.IncorrectGuesses++;
                }
            }

            await wordRepository.SaveChangesAsync();
        }
    }
}
