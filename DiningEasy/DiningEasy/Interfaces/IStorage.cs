using System.Collections.Generic;

namespace DiningEasy
{
    public interface IStorage
    {
        IEnumerable<ICanteen> GetCanteens();

        IEnumerable<ICategory> GetCategories(ICanteen canteen);

        IEnumerable<IProduct> GetProducts(ICanteen canteen, ICategory category);
    }
}
