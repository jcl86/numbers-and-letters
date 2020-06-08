using System.Threading.Tasks;

namespace Calculator
{
    public interface IWordSearcher
    {
        Task<DictionaryWord> Search(string word);
    }
}
