using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        bool IsBooked { get; set; }
        double Fare { get; set; }
        double ActualPrice { get; set; }
        void Save(IRepository repository, IProduct productType);
        void Book(IRepository repository, IProduct productType);
    }
}
