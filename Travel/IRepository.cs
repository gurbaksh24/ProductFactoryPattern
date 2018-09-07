using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    interface IRepository
    {
        void InsertProduct(params string[] members);
        void UpdateProduct(int productId, bool bookingStatus, string product);
    }
}
