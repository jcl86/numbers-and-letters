using System.Collections.Generic;

namespace Calculator
{
    public interface INumbersGamePreparer
    {
        int CreateObjetive();
        IEnumerable<int> CreateNumbers();
    }
}
