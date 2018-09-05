using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    class AirProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Car";
        }
        public void Book()
        {
            Console.WriteLine("Air - Book");
        }
        public void Save()
        {
            Console.WriteLine("Air - Save");
        }
    }
}
