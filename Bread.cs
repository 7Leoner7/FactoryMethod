using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Bread : IProduct
    {
        private readonly string _name;
        private readonly decimal _price;

        public Bread(decimal price)
        {
            _name = "Хлеб";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }

        public decimal GetPrice() => _price;
    }
}
