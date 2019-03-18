using System.Collections.Generic;
using System.Linq;

namespace DiningEasy.Model
{
    public class StorageInbuilt : IStorage
    {
        static Canteen[] canteens =
        {
            new Canteen
            {
                Name = "Клюква",
                Info = "Шоссе Энтузиастов, 7",
                Categories = new[]
                {
                    new Category
                    {
                        Name = "Супы",
                        Products = new[]
                        {
                            new Product
                            {
                                Name = "Борщ",
                                Description = "Вкусный борщ",
                                Ingridients = "Вода, мясо",
                                Weight = 300,
                                Cost = 150
                            }
                        }
                    },
                    new Category { Name = "Салаты" },
                    new Category { Name = "Десерты" }
                }
            },
            new Canteen
            {
                Name = "Матрешка",
                Info = "Электродная, 1",
                Categories = new[]
                {
                    new Category
                    {
                        Name = "Супы",
                        Products = new[]
                        {
                            new Product
                            {
                                Name = "Борщ",
                                Description = "Вкусный борщ",
                                Ingridients = "Вода, мясо",
                                Weight = 300,
                                Cost = 150
                            }
                        }
                    },
                    new Category { Name = "Салаты" },
                    new Category { Name = "Десерты" }
                }
            },
            new Canteen
            {
                Name = "Емеля",
                Info = "Кочновский проезд, 3",
                Categories = new[]
                {
                    new Category
                    {
                        Name = "Супы",
                        Products = new[]
                        {
                            new Product
                            {
                                Name = "Борщ",
                                Description = "Вкусный борщ",
                                Ingridients = "Вода, мясо",
                                Weight = 300,
                                Cost = 150
                            }
                        }
                    },
                    new Category { Name = "Салаты" },
                    new Category { Name = "Десерты" }
                }
            },
        };

        public IEnumerable<ICanteen> GetCanteens()
        {
            return canteens.ToList();
        }
    }
}
