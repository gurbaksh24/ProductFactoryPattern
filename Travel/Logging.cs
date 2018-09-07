using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Logging: ILogger
    {
        private static Logging instance;

        private Logging()
        {
         
        }

        public static Logging Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logging();
                }
                return instance;
            }
        }

        public void Log(string msg)
        {
            using (FileStream savingfs = new FileStream(@"c:\LogFile.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(savingfs))
                {
                    sw.WriteLine(msg);
                    sw.WriteLine("---------------------");
                    sw.Flush();
                }
            }
        }
    }
}
