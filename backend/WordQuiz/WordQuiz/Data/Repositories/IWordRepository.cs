using WordQuiz.Models;

namespace WordQuiz.Data.Repositories
{
    public interface IWordRepository
    {
        Word CreateWord(Word word);
        void DeleteWord(string wordId);
        IEnumerable<Word> GetAllWords();
        Word GetWordById(string wordId);

        Word GetWordByOriginal(string wordId);
        Word GetWordByTranslation(string word);

        List<Word> GetAllWordsByOriginal(string wordOriginal);
        List<Word> GetAllWordsByTranslation(string wordT);
        Word UpdateWord(Word word);

        IEnumerable<Word> GetWordsByTopicId(string topicId);

        void AddRange(List<Word> words);



    }
}