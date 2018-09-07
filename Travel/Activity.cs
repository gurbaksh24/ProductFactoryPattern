using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Activity : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }
        public void Book(IRepository repository)
        {
            Activity activity = new Activity();
            int activityId;
            Console.WriteLine("Fill out the following details:");
            Console.Write("Activity ID: ");
            int.TryParse(Console.ReadLine(), out activityId);
            activity.Id = activityId;
            repository.UpdateProduct(activityId, true, "Activity");
        }

        public void Save(IRepository repository)
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
            repository.InsertProduct(activity.Id.ToString(), activity.Name, "Activity", activity.IsBooked.ToString());
        }
    }
}
