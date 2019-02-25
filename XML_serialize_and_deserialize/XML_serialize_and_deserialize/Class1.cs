using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_serialize_and_deserialize
{
    class Class1
    {
        public class markalar
        {
            public string ad;
            //public menu menu1;
            public List<marka> menuList;
        }

        [Serializable]
        public class menu
        {
            [XmlAttribute]
            public string menuAdi;

            public string corba;
            public string anayemek;
            public string tatli;
        }

    }
}
