using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    interface IRepository
    {
        void InsertProduct(int productId, string productName, IProduct product, bool bookingStatus, double fare,double actualPrice);
        void UpdateProduct(int productId, bool bookingStatus, IProduct productType);
    }
}
