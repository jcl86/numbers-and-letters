using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class GamePreparer : IGamePreparer
    {
        private readonly int[] complexRow = new int[] { 10, 10, 25, 50, 75, 100 };

        private readonly Random random;

        public GamePreparer(Random random)
        {
            this.random = random;
        }

        public IEnumerable<int> CreateNumbers() => Enumerable.Range(0, 6).Select(x => CreateNumber());

        private int CreateNumber()
        {
            if (random.Next(0, 3) == 0)
            {
                return complexRow[random.Next(0, complexRow.Length)];
            }
            else return random.Next(1, 10);
        }

        public int CreateObjetive() => random.Next(101, 1000);
    }
}
