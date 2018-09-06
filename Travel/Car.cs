using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Car : FileHandling,IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }
        public Car()
        {
            
        }
        public void Book()
        {
            Console.WriteLine("Car Booked");
        }

        public void Save()
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
            InsertProduct(car.Id.ToString(),car.Name,car.IsBooked.ToString());
        }
    }
}
