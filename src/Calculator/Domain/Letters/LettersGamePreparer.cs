using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class LettersGamePreparer
    {
        private readonly Random random;
        private const string vowels = "aeiou";
        private const string consonants = "bcdfghjklmnñpqrstvwxyz";

        public LettersGamePreparer(Random random)
        {
            this.random = random;
        }

        private bool RandomBool => random.Next(0, 2) == 1;
        private char GetVowel => vowels[random.Next(0, vowels.Length)];
        private char GetConsonant => consonants[random.Next(0, consonants.Length)];

        public IEnumerable<char> CreateDeck() => Enumerable.Range(0, 10).Select(x => RandomBool ? GetVowel : GetConsonant);
    }
}
