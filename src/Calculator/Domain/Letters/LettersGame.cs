using System.Collections.Generic;

namespace Calculator
{
    public class LettersGame
    {
        public IEnumerable<char> Letters { get; }

        public LettersGame(LettersGamePreparer gamePreparer)
        {
            Letters = gamePreparer.CreateDeck();
        }
    }
}
