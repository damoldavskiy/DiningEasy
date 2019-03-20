using System.Collections.Generic;
using System.Linq;

namespace DiningEasy.Model
{
    public static class Basket
    {
        static List<IProduct> products = new List<IProduct>();

        /// <summary>
        /// Полная стоимость корзины
        /// </summary>
        public static int FullCost
        {
            get
            {
                return products.Sum(p => p.Cost);
            }
        }

        /// <summary>
        /// Список продуктов
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IProduct> Get()
        {
            return products.ToList();
        }

        /// <summary>
        /// Добалвение продукта
        /// </summary>
        /// <param name="product"></param>
        public static void Add(IProduct product)
        {
            products.Add(product);
        }

        /// <summary>
        /// Удаление продукта
        /// </summary>
        /// <param name="product"></param>
        public static void Remove(IProduct product)
        {
            products.Remove(product);
        }

        /// <summary>
        /// Очистка корзины
        /// </summary>
        public static void Clear()
        {
            products.Clear();
        }
    }
}
