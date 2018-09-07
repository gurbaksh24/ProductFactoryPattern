using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Hotel : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }
        public void Book(IRepository repository)
        {
            Hotel hotel = new Hotel();
            int hotelId;
            Console.WriteLine("Fill out the following details:");
            Console.Write("Hotel ID: ");
            int.TryParse(Console.ReadLine(), out hotelId);
            hotel.Id = hotelId;
            repository.UpdateProduct(hotel.Id, true, "Hotel");
        }

        public void Save(IRepository repository)
        {
            Hotel hotel = new Hotel();
            int hotelId;
            Console.WriteLine("Fill out the following details:");
            Console.Write("Hotel ID: ");
            int.TryParse(Console.ReadLine(), out hotelId);
            hotel.Id = hotelId;
            Console.Write("Hotel Name: ");
            hotel.Name = Console.ReadLine();
            IsBooked = false;
            repository.InsertProduct(hotel.Id.ToString(), hotel.Name, "Hotel", hotel.IsBooked.ToString());
        }
    }
}
