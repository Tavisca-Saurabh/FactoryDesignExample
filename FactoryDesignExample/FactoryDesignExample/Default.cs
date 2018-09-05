using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    class Default:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Not Found";
        }
        public void Book()
        {
            Console.WriteLine("Not Found");
        }
        public void Save()
        {
            Console.WriteLine("Not Found");
        }
    }
}
