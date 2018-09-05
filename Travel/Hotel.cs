using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Hotel : IProduct
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public bool IsBooked { get; set; }
        public string Address { get; set; }
        public void Book()
        {
            Console.WriteLine("Hotel Booked");
        }

        public void Save()
        {
            Console.WriteLine("Saved Hotel Details");
        }
    }
}
