using System;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Sınıf nasıl oluşturulur
            // class <isim> notasyonu ile oluşturulur
            // 
            // class A
            // {
            // .....
            // }
            #endregion

            #region Sınıf nerde oluşturulur
            // . namespace içinde
            // . namespace dışında
            // . class içinde (nested)

            // Bir class tanımlanmasında , tanımlandığı yerde aynı isimden başka bir class tanımlanamaz

            #endregion

            Ogrenci ogr1 = new Ogrenci();
            
            ogr1.adsoyad = "Ümit Karaçivi";
            ogr1.ders = "Fizik";
            ogr1.dersnotu = 60;
            ogr1.sinif = "12A";
            ogr1.tcno = "12345678901";

            ogr1.OgrenciYaz();
            
            ogr1.NotKontrol(ogr1.dersnotu);
            
            
            Console.ReadKey();


        }
    }

    class A
    {
        class B
        {

        }
    }

    class Ogrenci
    {
        public string adsoyad;
        public string sinif;
        public string ders;
        public string tcno;
        public int dersnotu;

        public void NotKontrol(int dersnotu)
        {
            if (dersnotu < 45)
            {
                Console.WriteLine("Dersten Kaldınız");
            }
            else
            {
                Console.WriteLine("Dersten Geçtiniz");
            }
        }

        public void OgrenciYaz()
        {
            Console.WriteLine("Öğrencinin Adı {0}  Sınıfı {1}  Tc No {2} Dersi {3}", adsoyad, sinif, tcno, ders);
        }
    }
}
