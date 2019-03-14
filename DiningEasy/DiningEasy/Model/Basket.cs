using System.Collections.Generic;
using System.Linq;

namespace DiningEasy.Model
{
    public static class Basket
    {
        static List<IProduct> products = new List<IProduct>();

        public static int FullCost
        {
            get
            {
                return products.Sum(p => p.Cost);
            }
        }

        public static IEnumerable<IProduct> Get()
        {
            return products.ToList();
        }

        public static void Add(IProduct product)
        {
            products.Add(product);
        }

        public static void Remove(IProduct product)
        {
            products.Remove(product);
        }

        public static void Clear()
        {
            products.Clear();
        }
    }
}
