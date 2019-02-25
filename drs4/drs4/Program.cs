using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drs4
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                byte bDegil = 288;
                int iDegil = (int)bDegil;

            }
            byte bDegil = 255;
            int iDegil = Convert.ToInt32(bDegil);
            Console.ReadKey();
        }
    }
}
