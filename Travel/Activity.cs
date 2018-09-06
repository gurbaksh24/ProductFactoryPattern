using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Activity : FileHandling, IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }
        public void Book()
        {

        }

        public void Save()
        {
            Activity activity = new Activity();
            int activityId;
            Console.WriteLine("Fill out the following details:");
            Console.Write("Activity ID: ");
            int.TryParse(Console.ReadLine(), out activityId);
            activity.Id = activityId;
            Console.Write("Activity Name: ");
            activity.Name = Console.ReadLine();
            IsBooked = false;
            InsertProduct(activity.Id.ToString(), activity.Name, activity.IsBooked.ToString());
        }


    }
}
