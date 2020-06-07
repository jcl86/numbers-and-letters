namespace Calculator
{
    public interface IWordSearcher
    {
        DictionaryWord Search(string word);
    }

    public class WordSearcher : IWordSearcher
    {
        public DictionaryWord Search(string word)
        {
            throw new System.NotImplementedException();
        }
    }
}
