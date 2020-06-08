using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class AvaliableLetters
    {
        public IEnumerable<Letter> Letters { get; private set; }

        public AvaliableLetters(IEnumerable<char> letters)
        {
            Letters = letters.Select(x => new Letter(x)).ToList();
        }

        public bool FormWord(string word)
        {
            bool canBeFormed = true;
            Reset();
            foreach (var character in word)
            {
                var foundLetter = Letters
                    .Where(x => !x.IsUsed)
                    .FirstOrDefault(x => x.Equals(new Letter(character)));

                if (foundLetter is null)
                {
                    canBeFormed = false;
                }

                foundLetter?.Use();
            }

            return canBeFormed;
        }

        private void Reset()
        {
            foreach (var letter in Letters)
            {
                letter.Reset();
            }
        }
    }
}
