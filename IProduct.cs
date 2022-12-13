namespace FactoryMethod
{
    public interface IProduct
    {
        string Name { get; }
        string Description { get; set; }
        decimal GetPrice();
    }
}
