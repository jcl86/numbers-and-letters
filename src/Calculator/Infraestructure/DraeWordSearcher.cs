using System.Net.Http;
using System.Threading.Tasks;

namespace Calculator.Infraestructure
{
    public class DraeWordSearcher : IWordSearcher
    {
        private const string baseurl = "https://dle.rae.es/";
        private const string notFoundText = "no está en el Diccionario";
        private const string foundText = "Definición de palabra";

        private HttpClient CreateClient()
        {
            return new HttpClient()
            {
                BaseAddress = new System.Uri(baseurl)
            };
        }

        public async Task<DictionaryWord> Search(string word)
        {
            using (var client = CreateClient())
            {
                var response = await client.GetAsync(word.Trim());
                string content = await response.Content.ReadAsStringAsync();

                if (content.Contains(notFoundText))
                {
                    return null;
                }

                return new DictionaryWord(word, $"{baseurl}{word}");
            }
        }
    }
}
