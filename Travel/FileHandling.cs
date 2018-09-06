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
        public void InsertProduct(params string[] members)
        {
            using (FileStream savingfs = new FileStream(@"c:\SaveFile.txt", FileMode.Append,FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(savingfs))
                {
                    foreach (string memberIndex in members)
                    {
                        sw.WriteLine(memberIndex);
                    }
                    sw.WriteLine("---------------------");
                    sw.Flush();
                }
            }
        }
        
    }
}
