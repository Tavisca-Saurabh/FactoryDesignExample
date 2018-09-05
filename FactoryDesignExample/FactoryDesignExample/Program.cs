using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FactoryDesignExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Type");
            string description = Console.ReadLine();
            IProduct product = GetProduct(description);
            product.GetTypeOfProduct();
            product.Book();
            product.Save();
            Console.ReadKey();

        }
        private static IProduct GetProduct(string desc)
        {
            switch (desc)
            {
                case "Car":
                    return new CarProduct();
                case "Air":
                    return new AirProduct();
                default:
                    return new Default();
            }
        }
    }
}
