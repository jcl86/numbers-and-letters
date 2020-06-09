using System;
using System.Collections;
using System.Linq;

namespace Calculator
{
    public class DictionaryWord
    {
        private readonly string word;

        public string Url { get; }

        public DictionaryWord(string word, string url)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentNullException(nameof(word));
            }

            if (word.Length < 1)
            {
                throw new ArgumentException("Can not form a word with no letters");
            }

            this.word = word.Trim();
            Url = url;
        }

        public int Length => word.Length;

        public int Stars()
        {
            if (Length > 8) return 5;
            if (Length > 6) return 4;
            if (Length > 4) return 3;
            if (Length > 2) return 2;
            return 1;
        }

        public override string ToString() => word.First().ToString().ToUpper() + word.Substring(1);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            if (obj is DictionaryWord other)
            {
                return other.word.Equals(word);
            }
            return false;
        }

        public override int GetHashCode() => word.GetHashCode();
    }
}
