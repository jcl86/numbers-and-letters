using System.Threading.Tasks;

namespace Calculator
{
    public class AlwaysFinderWordSearcher : IWordSearcher
    {
        public Task<DictionaryWord> Search(string word)
        {
            return Task.FromResult(new DictionaryWord(word.Trim(), "http://"));
        }
    }
}
