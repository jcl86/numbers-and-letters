using Calculator.Pages.LetterPages;
using System.Collections.Generic;

namespace Calculator
{
    public class LettersGame
    {
        public AvaliableLetters AvaliableLetters { get; }
        public List<DictionaryWord> WordList { get; }

        public LettersGame(LettersGamePreparer gamePreparer)
        {
            AvaliableLetters = new AvaliableLetters(gamePreparer.CreateDeck());
            WordList = new List<DictionaryWord>();
        }

        public void AddWord(DictionaryWord word)
        {
            if (!WordList.Contains(word))
            {
                WordList.Add(word);
            }
        }
    }
}
