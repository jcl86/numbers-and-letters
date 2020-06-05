using System.Collections.Generic;

namespace Calculator
{
    public interface IGamePreparer
    {
        int CreateObjetive();
        IEnumerable<int> CreateNumbers();
    }
}
