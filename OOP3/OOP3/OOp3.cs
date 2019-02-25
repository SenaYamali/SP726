using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class OOp3
    {
        //----------------------------YIKICI METOT----------------------------------
       ~OOp3()// nesen sonlandırıken veriyi işler 
        {
            Console.WriteLine("Nesne Çöpe Gidiyor!!!");
            Console.ReadKey();
        }

        public void Merhaba ()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
