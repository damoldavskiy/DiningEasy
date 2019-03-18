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
                        Path="Images\\Categories\\Sup.jpg",
                        Name = "Супы",
                        Products = new[]
                        {
                            new Product
                            {
                                Name = "Борщ",
                                Description = "Вкусный борщ со сметаной в лучших традициях русской кухни.",
                                Ingridients = "Вода, свекла, картошка, мясо, зелень, сметана",
                                Weight = 300,
                                Cost = 150
                            },
                            new Product
                            {
                                Name = "Щи",
                                Description = "Постные щи идеально подойдут для тех, кто следит за своей фигурой.",
                                Ingridients = "Вода, капуста, картошка, лук, залень",
                                Weight = 300,
                                Cost = 130
                            },
                            new Product
                            {
                                Name = "Уха",
                                Description = "Захотелось чего то новенького? Попробуйте фирменной ухи от шеф-повара!",
                                Ingridients = "Вода, мясо",
                                Weight = 200,
                                Cost = 180
                            }
                        }
                    },
                    new Category
                    {
                        Path="..\\Images\\Categories\\Grecheskij.jpg",
                        Name = "Салаты",
                        Products = new[]
                        {
                            new Product
                            {
                                Name = "Греческий",
                                Description = "Низкокаллорийный салат с индейкой специально для тех, кто следит за своей фигурой.",
                                Ingridients = "Огурцы, салат, помидоры, сыр, майонез",
                                Weight = 200,
                                Cost = 100
                            },
                            new Product
                            {
                                Name = "Цезарь",
                                Description = "Вкусный, легкий салат для истиных гурманов.",
                                Ingridients = "Салат, сыр, сметана, чеснок, майонез",
                                Weight = 200,
                                Cost = 120
                            },
                            new Product
                            {
                                Name = "Оливье",
                                Description = "Хотите попробовать что то из национальных русских блюд? Пожалуйста)",
                                Ingridients = "Яйцо, картошка, сыр, колбаса, майонез",
                                Weight = 150,
                                Cost = 90
                            },
                        }
                    },
                    new Category {
                        Path="..\\Images\\Categories\\Desert.jpg",
                        Name = "Десерты" ,
                        Products = new[]
                        {
                        new Product
                            {
                                Name = "Печенье",
                                Description = "Вкусное печенье с шоколадной крошкой для тех, кто любит побаловать себя сладким.",
                                Ingridients = "Мука, вода, масло, какао",
                                Weight = 100,
                                Cost = 80
                            },
                        new Product
                            {
                                Name = "Яблочный штрудель",
                                Description = "Подойдет настоящим гурманам, подается с мороженым)",
                                Ingridients = "Мука, вода, масло, яблки, сахар, яйца",
                                Weight = 200,
                                Cost = 200
                            },
                        }
                    }
                }
            },
            new Canteen
            {
                Name = "Матрешка", Info = "Электродная, 1",
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
                                Description = "Вкусный борщ со сметаной в лучших традициях русской кухни.",
                                Ingridients = "Вода, свекла, картошка, мясо, зелень, сметана",
                                Weight = 300,
                                Cost = 150
                            },
                            new Product
                            {
                                Name = "Щи",
                                Description = "Постные щи идеально подойдут для тех, кто следит за своей фигурой.",
                                Ingridients = "Вода, капуста, картошка, лук, залень",
                                Weight = 300,
                                Cost = 130
                            }
                        }
                    },
                    new Category
                    {
                        Name = "Салаты",
                        Products = new[]
                        {
                            new Product
                            {
                                Name = "Греческий",
                                Description = "Низкокаллорийный салат с индейкой специально для тех, кто следит за своей фигурой.",
                                Ingridients = "Огурцы, салат, помидоры, сыр, майонез",
                                Weight = 200,
                                Cost = 100
                            },
                            new Product
                            {
                                Name = "Цезарь",
                                Description = "Вкусный, легкий салат для истиных гурманов.",
                                Ingridients = "Салат, сыр, сметана, чеснок, майонез",
                                Weight = 200,
                                Cost = 120
                            },
                            new Product
                            {
                                Name = "Оливье",
                                Description = "Хотите попробовать что то из национальных русских блюд? Пожалуйста)",
                                Ingridients = "Яйцо, картошка, сыр, колбаса, майонез",
                                Weight = 150,
                                Cost = 90
                            },
                        }
                    },
                    new Category {
                        Name = "Напитки" ,
                        Products = new[]
                        {
                        new Product
                            {
                                Name = "Чай",
                                Description = "Хотите согреться? Наш ароматнейший чай поможет вам в этом)",
                                Ingridients = "Листовой чай, вода",
                                Weight = 200,
                                Cost = 30
                            },
                        new Product
                            {
                                Name = "Кофе",
                                Description = "Поможет вам взбодриться сонным пасмурным утром и не только)",
                                Ingridients = "Кофейный зерна, вода",
                                Weight = 200,
                                Cost = 100
                            },
                        }
                    }
                }
            },
            new Canteen
            {
                Name = "Емеля", Info = "Кочновский проезд, 3",
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
                                Description = "Вкусный борщ со сметаной в лучших традициях русской кухни.",
                                Ingridients = "Вода, свекла, картошка, мясо, зелень, сметана",
                                Weight = 300,
                                Cost = 150
                            },
                            new Product
                            {
                                Name = "Уха",
                                Description = "Захотелось чего то новенького? Попробуйте фирменной ухи от шеф-повара!",
                                Ingridients = "Вода, мясо",
                                Weight = 200,
                                Cost = 180
                            }
                        }
                    },
                    new Category
                    {
                        Name = "Салаты",
                        Products = new[]
                        {
                            new Product
                            {
                                Name = "Греческий",
                                Description = "Низкокаллорийный салат с индейкой специально для тех, кто следит за своей фигурой.",
                                Ingridients = "Огурцы, салат, помидоры, сыр, майонез",
                                Weight = 200,
                                Cost = 100
                            },
                            new Product
                            {
                                Name = "Оливье",
                                Description = "Хотите попробовать что то из национальных русских блюд? Пожалуйста)",
                                Ingridients = "Яйцо, картошка, сыр, колбаса, майонез",
                                Weight = 150,
                                Cost = 90
                            },
                        }
                    },
                    new Category {
                        Name = "Десерты" ,
                        Products = new[]
                        {
                        new Product
                            {
                                Path="..\\Images\\Products\\Cookie.jpg",
                                Name = "Печенье",
                                Description = "Вкусное печенье с шоколадной крошкой для тех, кто любит побаловать себя сладким.",
                                Ingridients = "Мука, вода, масло, какао",
                                Weight = 100,
                                Cost = 80
                            },
                        new Product
                            {
                                Name = "Яблочный штрудель",
                                Description = "Подойдет настоящим гурманам, подается с мороженым)",
                                Ingridients = "Мука, вода, масло, яблки, сахар, яйца",
                                Weight = 200,
                                Cost = 200
                            },
                        }
                    }
                }
            },
        };

        public IEnumerable<ICanteen> GetCanteens()
        {
            return canteens.ToList();
        }
    }
}
