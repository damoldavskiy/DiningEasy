using System.Collections.Generic;
using System.Linq;

namespace DiningEasy.Model
{
    public class StorageInbuilt : IStorage
    {
        static Canteen[] canteens = 
            {
            new Canteen { Name = "Клюква", Info = "Шоссе Энтузиастов, 7" }, 
            new Canteen { Name = "Матрешка", Info = "Электродная, 1" },
            new Canteen { Name = "Емеля", Info = "Кочновский проезд, 3" },
            };

        static Category[] categories = 
            {
            new Category { Name = "Супы" },
            new Category { Name = "Салаты" },
            new Category { Name = "Десерты" }
            };
        static Product[] products = 
            {
            new Product { Name = "Борщ", Category = categories[0], Description = "Вкусный борщ", Ingridients = "Вода, мясо", Weight = 300, Cost = 150 } 
            };
        

        public IEnumerable<ICanteen> GetCanteens()
        {
            return canteens.ToList();
        }

        public IEnumerable<ICategory> GetCategories(ICanteen canteen)
        {
            return categories.ToList();
        }

        public IEnumerable<IProduct> GetProducts(ICanteen canteen, ICategory category)
        {
            return products.ToList();
        }
    }
}
