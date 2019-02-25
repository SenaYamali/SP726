using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string klasorAdi = "Proje Dosyalari";
            string klasorAdi2 = @"C:\FileIO"; // yer belirtme

            //Console.WriteLine(Directory.GetCurrentDirectory()); //& exe nin çalıştığı yeri buluyor.

            //Directory.CreateDirectory(klasorAdi);// klasör oluşturma
            //Directory.CreateDirectory(klasorAdi2);
            //Console.WriteLine("C:\\FileIO Oluşturulma Tarihi : ");
            //Console.WriteLine(Directory.GetCreationTime(klasorAdi2));
            //Directory.Delete(klasorAdi2);

            //bool KlasorVarMI = Directory.Exists(klasorAdi2);  // mevcut mu
            //if (KlasorVarMI)
            //{
            //    Console.WriteLine("Klasör mevcut");
            //}
            //else
            //{
            //    Console.Write("Klasör Yok \n");
            //    Directory.CreateDirectory(klasorAdi2);
            //    Console.Write("Klasör Oluşturuldu");
            //}



            //string yolC = @"C:\";
            //string[] CdekiKlasorler = Directory.GetFiles(yolC);
            //string[] CdekiKlasorler = Directory.GetFiles(yolC,"*.sys");
            //foreach (var item in CdekiKlasorler)
            //{
            //    Console.WriteLine(item);
            //}


            //string yolD = @"D:\";
            //string[] dosyaVeKlasorler = Directory.GetFileSystemEntries(yolD); // klasörleri listeler C deki
            //foreach (var item in dosyaVeKlasorler)
            //{
            //    Console.WriteLine(item);
            //}

            //string dosyaYolu = @"C:\FileIO";
            //Directory.CreateDirectory(dosyaYolu);
            //Console.WriteLine(Directory.GetDirectoryRoot(dosyaYolu)); //C:\ nerde olduğunbu gösterir.
            //Console.WriteLine(Directory.GetLastAccessTime(dosyaYolu)); // en son ne zaman erişildiği
            //Console.WriteLine(Directory.GetLastWriteTime(dosyaYolu)); // en son ne zaman değiştirildiği
            //Console.WriteLine(Directory.GetCreationTime(dosyaYolu)); 



            //string[] logicalDrive = Directory.GetLogicalDrives();
            //foreach (var item in logicalDrive)
            //{
            //    Console.WriteLine(item); // mantıksal driverları gösterir C:\D:\E:\
            //}

            //Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory())); // getparent bir üst klasörü döndürür.


            //string kaynakDosyaYolu= @"C:\FileIO";
            //string hedefDosyaYolu= @"C:\Sena\FileIO";
            //Directory.Move(kaynakDosyaYolu, hedefDosyaYolu); // hedef de fileıo oluşturulmaması lazım taşıma yapıyor

            //string DosyaYolu = @"C:\Sena\FileIO";
            //DateTime simdi = DateTime.Now;
            //Directory.SetLastAccessTime(DosyaYolu, simdi);
            //Directory.SetLastWriteTime(DosyaYolu, simdi);
            //Directory.SetCreationTime(DosyaYolu, simdi); // son güncel tarihi değiştirdi.


            //Console.WriteLine(Directory.GetLastAccessTime(DosyaYolu));
            //Console.WriteLine(Directory.GetCreationTime(DosyaYolu));
            //Console.WriteLine(Directory.GetLastWriteTime(DosyaYolu));



            //Console.WriteLine(Directory.GetCurrentDirectory());
            //string orjinalYol = @"C:\Users\sena.yamali\documents\visual studio 2015\Projects\FileIO\FileIO\bin\Debug";
            //string yeniYol = @"C:\Sena";
            //Directory.SetCurrentDirectory(orjinalYol); // projenin yolunu değistirir.
            //Console.WriteLine(Directory.GetCurrentDirectory());



            //------------------------------ Olduğu günün tarihini alan klasör programı


            //string dosyaİsim = @"C:\"+DateTime.Now.ToShortDateString().Replace(".","_");

            //bool KlasorVarMI = Directory.Exists(dosyaİsim);  
            //if (KlasorVarMI)
            //{
            //    Console.WriteLine("Klasör mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Klasör Yok \n");
            //    Directory.CreateDirectory(dosyaİsim);
            //    Console.WriteLine("Klasör Oluşturuldu");
            //}

            //Console.WriteLine("Son Yazılma Tarihi :"+Directory.GetLastWriteTime(dosyaİsim));




            //-------------------------------------FİLE---------------------------------------

            //string dosyaYolu = "C:\\FileIO\\FileIO.txt";
            //string destdosyaYolu = "C:\\Sena\\FileIO.txt";

            ////Console.WriteLine(File.Exists(dosyaYolu));
            ////File.Copy(dosyaYolu, destdosyaYolu, true);
            ////File.Move(dosyaYolu,destdosyaYolu);

            //Console.WriteLine(File.GetAttributes(destdosyaYolu));
            //// File.SetAttributes(destdosyaYolu, FileAttributes.Hidden);// gizli dosya
            //File.SetAttributes(destdosyaYolu, FileAttributes.Normal);
            ////File.SetAttributes(destdosyaYolu, FileAttributes.ReadOnly);// salt okunur
            //Console.WriteLine(File.GetAttributes(destdosyaYolu));



            // -------------------------FileStream------------------------------

            // Dosyaya veri akış kanalı açıyoruz.Bu akış yolunu kullanarak okuma ve yazmma işlemi yapıyoruz.


            //string dosyaYolu = "C:\\Sena\\FileIO.txt";
            //FileStream fs = new FileStream(dosyaYolu,FileMode.Open); // dosyayla program arasında otoyol gibi yol açıor
            //StreamReader sr = new StreamReader(fs,Encoding.Default); // dosyanın içindek verileri bize veriyor
            //// encoding türkçe karakter uyyumu yapar
            //string satir;
            //int i = 1;
            //while ((satir=sr.ReadLine())!=null) //satır satır oku 
            //{
            //    Console.WriteLine($"Satır {i} : "+satir);
            //    i++;
            //}

            //fs.Close();



            //------------------------FileStream StreamWriter


            //string dosyaYolu = "C:\\Sena\\FileIO.txt";
            //FileStream fs = new FileStream(dosyaYolu, FileMode.Append, FileAccess.Write);
            ////FileStream fs = new FileStream(dosyaYolu, FileMode.Truncate,FileAccess.Write);// siliyor dosyayının içindekini 
            ////FileStream fs = new FileStream(dosyaYolu, FileMode.Create,FileAccess.Write);// Dosya yı yeni oluşturuyor

            //StreamWriter sw = new StreamWriter(fs, Encoding.Default);

            //while (true) //döngüm hep çalışssın 
            //{
            //    Console.WriteLine("Yazı Giriniz : ");
            //    string yazi = Console.ReadLine();
            //    if (yazi.ToLower()=="q") // Büyük de girse küçükte girse hepp küçük yapıyor
            //    {
            //        break;
            //    }
            //    sw.WriteLine(yazi);
            //}

            //sw.Flush(); // bellekteki veriyi dosyaya yaz
            //sw.Close();


            //    //sw.WriteLine("Merhaba C#");
            //   //sw.WriteLine("Beşiktaş");
            //   //sw.WriteLine("Sarıyer");

            //----------------------- SORU-------------------------------

            
            FileStream fls = new FileStream("C:\\Sena\\Ogrenciler.txt" , FileMode.Append, FileAccess.Write);
            StreamWriter smr = new StreamWriter(fls, Encoding.Default);
            while (true)
            {
                Console.Write("İsim Giriniz : ");
                string isim = Console.ReadLine();

            
                if (isim.ToLower()=="kapat")
                {
                    break;
                    
                }
                smr.Write("Öğrenci Adı :" + isim + "  ");
                Console.Write("Tc Giriniz : ");
                string tc = Console.ReadLine();
                if (tc.ToLower() == "kapat")
                {
                    break;

                }
                
                
                smr.WriteLine("Tc Kimlik No:"+tc);
            
            }
            smr.Flush();
            smr.Close();

            Console.ReadKey();
        }
    }
}
