namespace DiningEasy
{
    public interface IProduct
    {
        string Name { get; set; }

        string Path { get; set; }

        string Description { get; set; }

        string Ingridients { get; set; }

        int Weight { get; set; }

        int Cost { get; set; }
    }
}
