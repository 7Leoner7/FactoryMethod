using System;

namespace FactoryMethod
{
    public class TomatosFactory : ProductFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public TomatosFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IProduct GetProduct()
        {
            Tomatos tomatos = new Tomatos(_price)
            {
                Description = _description,
            };
            return tomatos;
        }
    }
}
