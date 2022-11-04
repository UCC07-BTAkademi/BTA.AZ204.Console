using System;

//this
// this anahtar sözcüğü sınıfın geçerli üye/üyelerine erişimi sağlar. Metot içerisinde bulunan benzer değişken adlarında this ile sınıfın üyeleri ile metodun üyeleri arasında ayrım sağlar.

// get,set keyword
// Özellik metotları GET ve SET anahtar kelimesinden oluşan iki kod bloğundan oluşurlar. GET metodu veri okunduğu zaman, SET metodu ise veri yazıldığı zaman(yani değer ataması yapıldığı zaman) yürütülür.Özellik olarak bu iki anahtar kelimeyi aynı anda kullanabildiğimiz gibi, tek anahtar kelime ile de oluşturabiliriz.


// Enumaration (Enum) yapısı
// Değişkenlerin alabileceği değerlerin sabit (belli) olduğu durumlarda programı daha okunabilir hale getirmek için kullanılır. Programda birçok değişkene tek tek sayısal değer vermek yerine "enum" yapısı  kullanılabilir.

namespace GetSetThis
{
    class Program
    {
        enum PlakaList
        {
            Ankara=6,
            Kocaeli=41,
            İzmir=35,
            Adana=1,
            Bursa=16,
            İstanbul=34
        }



        static void Main(string[] args)
        {

            #region this + constructor (yapıcı metot)

            //Programci programci1 = new Programci();

            //Programci programci2 = new Programci("Barış", 28);

            //Programci programci3 = new Programci("Metin", "Demirkıran", 34);

            //Programci programci4 = new Programci("Ümit", "Karaçivi", 58, "C#");


            //programci1.Goster();

            //programci2.Goster();

            //programci3.Goster();

            //programci4.Goster();

            #endregion

            #region get,set

            //Urun urun = new Urun();

            //urun.UrunNo = 1;
            //urun.UrunAd = "Domates";
            //urun.Miktar = 100;
            //urun.AlisFiyat = 10;


            //Console.WriteLine("Ürün No : {0}",urun.UrunNo);
            //Console.WriteLine("Ürün Adı : {0}", urun.UrunAd);
            //Console.WriteLine("Ürün Miktar : {0}", urun.Miktar);
            //Console.WriteLine("Ürün Alış Fiyatı : {0}", urun.AlisFiyat);
            //Console.WriteLine("Ürün Satış Fiyatı : {0}", urun.SatisFiyat);
            //Console.WriteLine("Kar : {0}", urun.Kar);

            #endregion


            #region enum : Numaralandırma türleri

            int plakano = 34;

            PlakaList sehirad = (PlakaList)plakano;

            Console.WriteLine("Şehir Adı : {0}",sehirad);



            #endregion



            Console.ReadKey();
        }
    }

    class Programci
    {
        string adi;
        string soyadi;
        int yas;
        string kullandigiDil;

        public Programci() // Hiç parametre almayan bir constructor...
        {
            this.adi = null;
            this.soyadi = null;
            this.yas = 0;
            this.kullandigiDil = null;

        }

        public Programci(string adi,int yas) // ad,yas bilgilerini alan bir parametreli constructor
        {
            this.adi = adi;
            this.yas = yas;
            this.soyadi = null;
            this.kullandigiDil = null;
        }

        public Programci(string adi, string soyadi,int yas) // ad,soyad,yas bilgilerini alan bir parametreli constructor
        {
            this.adi = adi;
            this.yas = yas;
            this.soyadi = soyadi;
            this.kullandigiDil = null;
        }

        public Programci(string adi, string soyadi,int yas,string kullandigiDil) // ad,soyad,yas,dil bilgilerini alan bir parametreli constructor
        {
            this.adi = adi;
            this.yas = yas;
            this.soyadi = soyadi;
            this.kullandigiDil = kullandigiDil;
        }

        public void Goster()
        {
            if (this.yas != 0)
                Console.WriteLine("Yaşı : " + this.yas);
            else
                Console.WriteLine("Yaş bilgisi elimizde yok !");

            if (this.adi != null)
                Console.WriteLine("Adı : " + this.adi);
            else
                Console.WriteLine("Ad bilgisi mevcut değil !");

            if (this.soyadi != null)
                Console.WriteLine("Soyadı : " + this.soyadi);
            else
                Console.WriteLine("Soyad bilgisi mevcut değil !");

            if (this.kullandigiDil != null)
                Console.WriteLine("Dil : " + this.kullandigiDil);
            else
                Console.WriteLine("Hangi dili kullandığını şu an için bilemiyoruz... Görcez...");

        }





    }

    class Urun
    {
        string urunad;

        public string UrunAd
        {
            get { return urunad; } // o anki class içi değişgenin değerini okur/getirir
            set { urunad = value; }
        }

        int urunno;

        public int UrunNo
        {
            get { return urunno; } // o anki class içi değişgenin değerini okur/getirir
            set { urunno = value; }
        }

        int miktar;

        public int Miktar
        {
            get { return miktar; } // o anki class içi değişgenin değerini okur/getirir
            set { miktar = value; }
        }

        int alisfiyat;

        public int AlisFiyat
        {
            get { return alisfiyat; } // o anki class içi değişgenin değerini okur/getirir
            set { alisfiyat = value; }
        }

        float satisfiyat;

        public float SatisFiyat
        {
            get {
                satisfiyat = (float)((float)alisfiyat * 1.1);
                return satisfiyat;

                } // o anki class içi değişgenin değerini okur/getirir

            //set { satisfiyat = value; }
        }

        public float Kar
        {
            get { return (float)miktar * (float)(satisfiyat - alisfiyat); }
        }

        public Urun() // Kurucu metot
        {
            urunad = "";
            urunno = 0;
            miktar = 0;
            alisfiyat = 0;
            satisfiyat = 0;
        }




    }



}
