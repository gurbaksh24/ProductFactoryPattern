using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class FareStrategy : IFareCalculate
    {
        public double CalculateFare(double actualPrice,IProduct productType)
        {
            switch(productType.GetType().Name)
            {
                case "Air":
                    return (actualPrice + actualPrice * 10 / 100);
                case "Activity":
                    return (actualPrice + actualPrice * 20 / 100);
                case "Car":
                    return (actualPrice + actualPrice * 30 / 100);
                case "Hotel":
                    return (actualPrice + actualPrice * 40 / 100);
                default:
                    Console.WriteLine("Error");
                    return 0;
            }
        }
    }
}
