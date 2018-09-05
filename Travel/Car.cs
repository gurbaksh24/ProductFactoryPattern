using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Car : IProduct
    {
        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public bool IsBooked { get; set; }
        public Car()
        {
            int carId;
            Console.WriteLine("Fill out the following details:");
            Console.Write("Car ID: ");
            int.TryParse(Console.ReadLine(),out carId);
            CarId = carId;
            Console.Write("Car Brand: ");
            CarBrand = Console.ReadLine();
            Console.Write("Car Model: ");
            CarModel = Console.ReadLine();
            IsBooked = false;
        }
        public void Book()
        {
            Console.WriteLine("Car Booked");
        }

        public void Save()
        {
            Console.WriteLine("Saved Car Details");
        }
    }
}
