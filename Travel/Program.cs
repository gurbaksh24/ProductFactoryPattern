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
            Console.WriteLine("Activity");
            Console.WriteLine("Air");
            Console.WriteLine("Car");
            Console.WriteLine("Hotel");
            string productName = Console.ReadLine();
            Logging.Instance.Log("Called GetProduct() method In ProductFactory class from the Main() method in the Program class");
            IProduct product = ProductFactory.GetProduct(productName);
            Console.WriteLine("Enter the name of the Data Handling");
            Console.WriteLine("FileHandling");
            Console.WriteLine("SqlHandling");
            string repoName = Console.ReadLine();
            IRepository repo = RepoFactory.GetRepo(repoName);
            while (true)
            {
                Console.WriteLine("1. Save Details");
                Console.WriteLine("2. Book");
                Console.WriteLine("3. Exit");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Logging.Instance.Log("Called Save() method of Program class from the Main() method in the Program class");
                        program.Save(product,repo);
                        break;
                    case 2:
                        Logging.Instance.Log("Called Book() method of Program class from the Main() method in the Program class");
                        program.Book(product, repo);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please choose a correct choice");
                        break;
                }
            }
        }
        void Save(IProduct product,IRepository repository)
        {
            Logging.Instance.Log("Called Save() method of IProduct Interface from the Save() method in the Program class");
            product.Save(repository,product);
        }
        void Book(IProduct product,IRepository repository)
        {
            Logging.Instance.Log("Called Book() method of IProduct Interface from the Save() method in the Program class");
            product.Book(repository,product);
        }
    }
}
