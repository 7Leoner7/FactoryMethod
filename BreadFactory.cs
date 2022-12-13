namespace FactoryMethod
{
    public class BreadFactory : ProductFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public BreadFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IProduct GetProduct()
        {
            Bread bread = new Bread(_price)
            {
                Description = _description,
            };
            return bread;
        }
    }
}
