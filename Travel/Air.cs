using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Air : FileHandling, IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }
        public void Book()
        {
            Console.WriteLine("Air Booked");
        }

        public void Save()
        {
            Air air = new Air();
            int activityId;
            Console.WriteLine("Fill out the following details:");
            Console.Write("Air ID: ");
            int.TryParse(Console.ReadLine(), out activityId);
            air.Id = activityId;
            Console.Write("Air Name: ");
            air.Name = Console.ReadLine();
            IsBooked = false;
            InsertProduct(air.Id.ToString(), air.Name, air.IsBooked.ToString());
        }
    }
}
