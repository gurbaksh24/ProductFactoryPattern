using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class FileHandling : IRepository
    {
        public void InsertProduct(IProduct product)
        {
            using (FileStream savingfs = new FileStream(@"c:\SaveFile.txt", FileMode.Append))
            {
                savingfs.Write(product.Id);
            }
        }
        
    }
}
