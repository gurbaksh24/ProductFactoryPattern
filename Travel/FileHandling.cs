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
        public void InsertProduct(int productId, string productName, IProduct product, bool bookingStatus, double fare, double actualPrice)
        {
            Logging.Instance.Log("Writing Content to file "+@"c:\SaveFile.txt");
            using (FileStream savingfs = new FileStream(@"c:\SaveFile.txt", FileMode.Append,FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(savingfs))
                {
                    sw.WriteLine(productId.ToString());
                    sw.WriteLine(productName);
                    sw.WriteLine(product.GetType().Name);
                    sw.WriteLine(bookingStatus);
                    sw.WriteLine(fare);
                    sw.WriteLine(actualPrice);
                    sw.WriteLine("---------------------------------");
                    sw.Flush();
                }
            }
            Console.WriteLine("Data Saved");
        }
        

        public void UpdateProduct(int productId, bool bookingStatus,IProduct productType)
        {
            Logging.Instance.Log("Updating Content of file " + @"c:\SaveFile.txt");
            string line,productLine;
            int count =0;
            FareStrategy fareStrategy = new FareStrategy();
            FileStream file = new FileStream(@"c:\SaveFile.txt", FileMode.OpenOrCreate, FileAccess.Write);
            file.Close();
            using (StreamReader reader = new StreamReader(@"c:\SaveFile.txt"))
            using (StreamWriter writer = new StreamWriter(@"c:\temp.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (count % 7 == 0 && line.Equals(productId.ToString()))
                    {
                        int countLinesForProductType = 0;
                        productLine = line;
                        do
                        {
                            countLinesForProductType++;
                            if (countLinesForProductType == 3 && productLine.Equals(productType.GetType().Name))
                            {
                                writer.WriteLine(productLine);
                                reader.ReadLine();
                                writer.WriteLine(bookingStatus);
                                writer.WriteLine(reader.ReadLine());
                                writer.WriteLine(fareStrategy.CalculateFare(double.Parse(reader.ReadLine()), productType));
                            }
                            else
                            {
                                writer.WriteLine(productLine);
                            }
                        } while ((productLine = reader.ReadLine()) != null && countLinesForProductType <= 3);
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            File.Delete(@"c:\SaveFile.txt");
            File.Move(@"c:\temp.txt", @"c:\SaveFile.txt");
            Console.WriteLine("Booked");
        }
        
    }
}
