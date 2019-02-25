using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_404
{
    public class Yonetmen
    {
        public int YonetmenId { get; set; }
        public string YonetmenAdSoyad { get; set; }
        [NotMapped]
        public DateTime YonetmenDogumTarihi {get; set;}
        public ICollection<Film> YonetmenFilmleri { get; set; }
        //public Film yonetmenId { get; set; }
    }
}
