using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Car : IProduct
    {
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
