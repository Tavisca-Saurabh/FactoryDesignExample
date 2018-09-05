using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    class CarProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Car";
        }
        public void Book()
        {
            Console.WriteLine("Car - Book");
        }
        public void Save()
        {
            Console.WriteLine("Car - Save");
        }
    }
}
