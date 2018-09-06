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
            Logging.Instance.Log("Called GetProduct() method In ProductFactory class from the Main() method in the Program class");
            IProduct product = ProductFactory.GetProduct(productName);
            Logging.Instance.Log("Called Save() method of Program class from the Main() method in the Program class");
            program.Save(product);
            Console.ReadKey();
        }
        void Save(IProduct product)
        {
            Logging.Instance.Log("Called Save() method of IProduct Interface from the Save() method in the Program class");
            product.Save();
        }
        void Book(IProduct product)
        {
            Logging.Instance.Log("Called Book() method of IProduct Interface from the Save() method in the Program class");
            product.Book();
        }
    }
}
