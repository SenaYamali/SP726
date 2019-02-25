using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        { 
            string yolD = @"C:\TEST";
            string[] dosyaVeKlasorler = Directory.GetFiles(yolD);
            FileStream fls = new FileStream(yolD+"\\Silme.txt", FileMode.Append, FileAccess.Write);
            StreamWriter smr = new StreamWriter(fls, Encoding.Default);

            for (int i = 0; i < dosyaVeKlasorler.Length; i++)
            {
                TimeSpan time = DateTime.Now - File.GetLastWriteTime(dosyaVeKlasorler[i]);
                Console.WriteLine(time);
            }

           

            

            smr.Flush();
            smr.Close();
          fls.Close();

            Console.ReadKey();

        }
    }
}
