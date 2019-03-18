using System.Collections.Generic;

namespace DiningEasy
{
    public interface IStorage
    {
        IEnumerable<ICanteen> GetCanteens();
    }
}
