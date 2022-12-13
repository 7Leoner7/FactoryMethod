using System;

namespace FactoryMethod
{
    public class Tomatos : IProduct
    {
        private readonly string _name;
        private readonly decimal _price;

        public Tomatos(decimal price)
        {
            _name = "Помидор";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }

        public decimal GetPrice() => _price;
    }
}
