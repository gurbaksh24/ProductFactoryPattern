using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Activity : IProduct
    {
        public void Book()
        {
            Console.WriteLine("Activity Booked");
        }

        public void Save()
        {
            Console.WriteLine("Saved Activity Details");
        }
    }
}
