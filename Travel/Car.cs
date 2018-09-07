using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Car : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }
        
        public void Book(IRepository repository)
        {
            Car car = new Car();
            int carId;
            Console.WriteLine("Fill out the following details:");
            Console.Write("Car ID: ");
            int.TryParse(Console.ReadLine(), out carId);
            car.Id = carId;
            repository.UpdateProduct(car.Id, true, "Car");
        }

        public void Save(IRepository repository)
        {
            Car car = new Car();
            int carId;
            Console.WriteLine("Fill out the following details:");
            Console.Write("Car ID: ");
            int.TryParse(Console.ReadLine(), out carId);
            car.Id = carId;
            Console.Write("Car Name: ");
            car.Name = Console.ReadLine();
            IsBooked = false;
            repository.InsertProduct(car.Id.ToString(), car.Name, "Car", car.IsBooked.ToString());
        }
    }
}
