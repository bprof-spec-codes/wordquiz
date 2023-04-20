using WordQuiz.Models;

namespace WordQuiz.Logics
{
    public class WordEqualityComparer : IEqualityComparer<Word>
    {
        public bool Equals(Word x, Word y)
        {
            if (x == null || y == null)
                return false;

            return x.Original == y.Original && x.Translation == y.Translation;
        }

        public int GetHashCode(Word obj)
        {
            if (obj == null)
                return 0;

            int hashOriginal = obj.Original == null ? 0 : obj.Original.GetHashCode();
            int hashTranslation = obj.Translation == null ? 0 : obj.Translation.GetHashCode();

            return hashOriginal ^ hashTranslation;
        }
    }
}
