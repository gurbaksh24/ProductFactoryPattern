//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Travel
//{
//    class ProductServices:IProduct
//    {
//        public void Book(IRepository repository, IProduct productType)
//        {
//            Air air = new Air();
//            int activityId;
//            Console.WriteLine("Fill out the following details:");
//            Console.Write("Air ID: ");
//            int.TryParse(Console.ReadLine(), out activityId);
//            air.Id = activityId;
//            repository.UpdateProduct(air.Id, true, "Air");
//        }

//        public void Save(IRepository repository)
//        {
//            Air air = new Air();
//            int activityId;
//            Console.WriteLine("Fill out the following details:");
//            Console.Write("Air ID: ");
//            int.TryParse(Console.ReadLine(), out activityId);
//            air.Id = activityId;
//            Console.Write("Air Name: ");
//            air.Name = Console.ReadLine();
//            IsBooked = false;
//            Logging.Instance.Log("Called InsertProduct() method of IRepository Interface from the Save() method in the Air class");
//            repository.InsertProduct(air.Id.ToString(), air.Name, "Air", air.IsBooked.ToString());
//        }
//    }
//}
