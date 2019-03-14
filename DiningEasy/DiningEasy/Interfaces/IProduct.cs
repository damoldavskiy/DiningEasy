namespace DiningEasy
{
    public interface IProduct
    {
        string Name { get; set; }

        ICategory Category { get; set; }

        string Description { get; set; }

        string Ingridients { get; set; }

        int Weight { get; set; }

        int Cost { get; set; }
    }
}
