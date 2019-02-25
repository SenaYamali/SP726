using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE_404
{
     public class Film
    {
        [KEY]
        public int FilmId { get; set; }
        public int FilmYonetmenID { get; set;}
        public string FilmAd { get; set; }

        [ForeignKey("FilmOyunculari")]
        public ICollection<Oyuncu>FilmOyunculari {get;set;}

        public Yonetmen YonetmenId { get; set;}
       
    }
}
