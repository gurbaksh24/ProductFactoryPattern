using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    interface IFareCalculate
    {
        double CalculateFare(double actualPrice,IProduct productType);
    }
}
