using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Enter the name of the product");
            string productName = Console.ReadLine();
            IProduct product = ProductFactory.GetProduct(productName);
            program.Book(product);
            Console.ReadKey();
        }
        void Book(IProduct product)
        {
            product.Save();
            product.Book();
        }
    }
}
