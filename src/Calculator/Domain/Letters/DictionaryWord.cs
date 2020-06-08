using System;
using System.Collections;

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

            this.word = word.Trim();
            Url = url;
        }

        public int Length => word.Length;

        public override string ToString() => word.ToString();

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
