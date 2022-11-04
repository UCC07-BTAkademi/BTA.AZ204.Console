using System;

class B
{

}

namespace Siniflar
{
    class Program
    {

        // Bir öğrenci bilgini tutacak/tanımlayacağımız bir class yaratalım
        // bu classdan bir nesne üretelim
        // hatta bu classın içinde bir iki metot olsun. bunları çağıralım
        // nesnemiz üzerinde verileri dolduralım...




        static void Main(string[] args)
        {

            #region Sınıflar nasıl oluşturulur..
            // class <sınıfımızın.ismi> notasyonuyla oluşturabiliriz



            #endregion

            #region Sınıflar nerelerde oluşturulabilir
            // . namespace içinde
            // . namesapce dışında
            // . class içinde de yaratılabiliyor..

            #endregion


            // bir nesne yaratmalık
            //Ogrenci ogr1 = new Ogrenci();
            //Ogrenci ogr2 = new Ogrenci();

            //ogr1.AdSoyad = "Ümit Karaçivi";
            //ogr1.Ders = "Fizik";
            //ogr1.DersNotu = 55;
            //ogr1.Sinif = "6FenA";
            //ogr1.TCKNo = "12345678901";

            //ogr1.OgrenciYaz();

            //ogr1.NotKontrol(ogr1.DersNotu);

            //ogr2.AdSoyad = "Doğa Karaçivi";
            //ogr2.Ders = "Sanat tarihi";
            //ogr2.DersNotu = 85;
            //ogr2.Sinif = "Sınıf 3";
            //ogr2.TCKNo = "12345678901";

            //ogr2.OgrenciYaz();

            //ogr2.NotKontrol(ogr2.DersNotu);


            //Tasit otomobil = new Tasit();
            //Tasit motor = new Tasit();

            //int yil = 2010;

            //otomobil.Marka = "Volvo";
            //otomobil.Model = "XC70";
            //otomobil.Renk = "Siyah";
            //otomobil.Yil = 2005;
            //otomobil.Info();



            //motor.Marka = "BMW";
            //motor.Model = "GS1200";
            //motor.Renk = "Beyaz";
            //motor.Yil = 2010;

            //motor.Info();

            //if (yil >= otomobil.Yil)
            //{
            //    Console.WriteLine("Otomobil kullanabilirsiniz");

            //}
            //else
            //{
            //    Console.WriteLine("Motor kullanabilirsiniz");
            //}


            // Yapıcı metot örneği

            Kutu kutu1 = new Kutu();
            kutu1.setGenislik(5);
            kutu1.setDerinlik(4);
            kutu1.setYukseklik(4);
            kutu1.HacimHesapla();

            Kutu kutu2 = new Kutu();
            kutu2.setGenislik(7);
            kutu2.setDerinlik(10);
            kutu2.setYukseklik(5);
            kutu2.HacimHesapla();

            Kutu kutu3 = new Kutu(); // sistemdefault değerlere göre yaratacak
            kutu3.HacimHesapla();


            Console.ReadKey();

        }
    }

    // Örnek bşir sınıf

    class Ogrenci
    {
        // Aşağıdakiler sınıfımın özellikleri/değişgenleri
        public string AdSoyad;
        public string Sinif;
        public string TCKNo;
        public string Ders;
        public int DersNotu;


        public void NotKontrol (int dersnotu)
        {
            if (dersnotu < 50)
            {
                Console.WriteLine("Dersten maalesef kaldınız..");
            }
            else
            {
                Console.WriteLine("Dersten geçtiniz...Hayatta başarılar..");
            }

        }

        public void OgrenciYaz()
        {
            Console.WriteLine("Öğrenci AdıSoyadı {0} Sınıfı {1}   TCKNo  {2}  Dersi  {3}", AdSoyad, Sinif, TCKNo, Ders);
        }


    }

    class Tasit
    {
        public string Marka;
        public string Renk;
        public string Model;
        public int Yil;

        public void Info()
        {
            Console.WriteLine("Marka: {0}  Model: {1} Renk : {2}  Yıl : {3}",Marka,Model,Renk,Yil);
        }



    }

    // Yapıcı kısım

    class Kutu
    {
        int genislik;
        int yukseklik;
        int derinlik;

        //Constructor (Yapıcı Metot) ---Nesne ilk yaratılırken otomatik çalışacak metot
        public Kutu()
        {
            Console.Write("Kutu oluşuyor");
            genislik = 6;
            yukseklik = 7;
            derinlik = 8;
        }

        public void setGenislik(int gen)
        {
            genislik = gen;
        }

        public void setYukseklik(int yuk)
        {
            yukseklik = yuk;
        }

        public void setDerinlik(int der)
        {
            derinlik = der;
        }

        public void HacimHesapla()
        {
            int hacim = genislik * yukseklik * derinlik;

            Console.WriteLine("\nKutumun hacmi = {0}", hacim);
        }


    }


}
