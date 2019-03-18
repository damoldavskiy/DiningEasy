using System.Collections.Generic;

namespace DiningEasy
{
    public interface ICategory
    {
        string Name { get; set; }

        IEnumerable<IProduct> Products { get; set; }
    }
}
