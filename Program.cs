using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> Welcome to mini-market!!!");
            Console.WriteLine("> Enter the type of products");
            Console.WriteLine("> T - Tomatos");
            Console.WriteLine("> B - Breads");

            string ProductType = Console.ReadLine();
            ProductFactory productFactory = GetFactory(ProductType);

            IProduct product = productFactory.GetProduct();

            Console.WriteLine("\n>>>Product has created\n");
            Console.WriteLine(
                $"\tName:\t\t{product.Name}\n" +
                $"\tDescription:\t{product.Description}\n" +
                $"\tPrice:\t\t{product.GetPrice()}\n"
                );
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        private static ProductFactory GetFactory(string productType) =>
            productType.ToLower() switch
            {
                "t" => new TomatosFactory(125, "Свежие кавказские помидоры"),
                "b" => new BreadFactory(150, "Свежий кубанский хлеб"),
                _ => null
            };
    }
}
