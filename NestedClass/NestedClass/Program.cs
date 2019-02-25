using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    //class KisiselBilgi
    //{
    //    public String Ad;
    //    public string Soyad;
    //    public YasBilgi _yasBilgisi = new YasBilgi();

       
    //    //Yukarıdaki nesne tanımlama sayesinde  
    //    //YasBiligisi sınıfın üyelerine bu sınıf nesenesi 
    //    //aracılığı ile değer atayabiliriz.
    //    //Metotlarını kullanabiliriz.

    //    public void Yazdir()
    //    {
    //        Console.WriteLine(Ad + " " + Soyad);
    //        Console.WriteLine(_yasBilgisi.Yas);
    //    }
    //}

    //class YasBilgi
    //{
    //    public int Yas;
    //    public void YasYazdir()
    //    {
    //        Console.WriteLine(Yas);
    //    }
    //}

        //---------------------------------Soru---------------------------------

        class Ogretmen
    {

        public string OgretmenAdi;
        public int OgretmenYasi;
        public Sınıf _Snf = new Sınıf();

        public void BilgiYazdır()
        {
            Console.WriteLine($"Öğretmen Adı : {OgretmenAdi}\nÖğretmen Yaşı : {OgretmenYasi}");
            Console.WriteLine("Sınıf Adı : "+_Snf.SinifAdi);
            Console.WriteLine("Derslik No : "+_Snf.DerslikNumarası);
            Console.WriteLine("Sınıf Programı : "+_Snf.SinifProgrami);

        }
    }
        class Sınıf
    {
        public string SinifAdi;
        public int DerslikNumarası;
        public string SinifProgrami;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogt = new Ogretmen();
            ogt.OgretmenAdi = "Mehmet Demir";
            ogt.OgretmenYasi = 30;
            ogt._Snf.SinifAdi = "723726";
            ogt._Snf.DerslikNumarası = 404;
            ogt._Snf.SinifProgrami = "Web ve Mobil Programlama";
            ogt.BilgiYazdır();


            //---------------------------Soru-----------------------------
            //KisiselBilgi kb1 = new KisiselBilgi();
            //kb1.Ad = "SmartPro";
            //kb1.Soyad = "Kadıköy";
            //kb1._yasBilgisi.Yas = 55;

            //kb1.Yazdir();
            Console.ReadKey();

        }
    }
}
