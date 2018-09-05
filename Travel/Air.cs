using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Air : IProduct
    {
        public void Book()
        {
            Console.WriteLine("Air Booked");
        }

        public void Save()
        {
            Console.WriteLine("Saved Air Details");
        }
    }
}
