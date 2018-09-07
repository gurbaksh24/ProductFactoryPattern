using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Car:IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }
        public double Fare { get; set; }
        public double ActualPrice { get; set; }
        public void Book(IRepository repository, IProduct productType)
        {
            ProductServices productServices = new ProductServices();
            productServices.Book(repository, productType);
        }
        public void Save(IRepository repository, IProduct productType)
        {
            ProductServices productServices = new ProductServices();
            productServices.Save(repository, productType);
        }
    }
}
