using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_404
{
     public class Oyuncu
    {
        public int OyuncuId { get; set; }
        public string OyuncuAdSoyad { get; set; }
        public DateTime OyuncuDogumTarihi { get; set; }
        public IList<Film> OyuncuFilmleri { get; set; }
    }
}
