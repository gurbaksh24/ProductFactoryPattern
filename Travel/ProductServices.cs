using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class ProductServices : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }
        public double Fare { get; set; }
        public double ActualPrice { get; set; }
        public void Book(IRepository repository, IProduct productType)
        {
            int productId;
            Console.WriteLine("Fill out the following details:");
            Console.Write("Product ID: ");
            int.TryParse(Console.ReadLine(), out productId);
            productType.Id = productId;
            repository.UpdateProduct(productType.Id, true, productType);
        }

        public void Save(IRepository repository, IProduct productType)
        {
            int productId;
            Console.WriteLine("Fill out the following details:");
            Console.Write("Product ID: ");
            int.TryParse(Console.ReadLine(), out productId);
            productType.Id = productId;
            Console.Write("Product Name: ");
            productType.Name = Console.ReadLine();
            Console.WriteLine("Product Fare: ");
            FareStrategy fareStrategy = new FareStrategy();
            double price= double.Parse(Console.ReadLine());
            productType.Fare = price;
            productType.ActualPrice = price;
            productType.IsBooked = false;
            Logging.Instance.Log("Called InsertProduct() method of IRepository Interface from the Save() method in the Air class");
            repository.InsertProduct(productType.Id, productType.Name, productType, productType.IsBooked, productType.Fare,productType.ActualPrice);
        }
    }
}
