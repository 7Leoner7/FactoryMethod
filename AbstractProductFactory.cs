using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract public class ProductFactory
    {
        public abstract IProduct GetProduct();
    }
}
