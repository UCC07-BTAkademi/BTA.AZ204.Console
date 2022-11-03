using System;

namespace GetSetThis
{
    class Program
    {
        enum PlakaList
        {
            Ankara = 6, 
            Kocaeli = 41, 
            İzmir = 35, 
            Adana = 1, 
            Bursa = 16,
            İstanbul=34
        }


        static void Main(string[] args)
        {
            // this
            // this anahtar sözcüğü sınıfın geçerli üye/üyelerine erişimi sağlar. Metot içerisinde bulunan benzer değişken adlarında this ile sınıfın üyeleri ile metodun üyeleri arasında ayrım sağlar.

            #region Örnek1 - this + constructor

            //Programci a = new Programci();
            //Programci b = new Programci(23, "Barış");
            //Programci c = new Programci(27, "Metin", "Yazılımcı");
            //Programci d = new Programci(58, "Ümit", "Karaçivi", "C#");


            //a.OzellikGoster();
            //b.OzellikGoster();
            //c.OzellikGoster();
            //d.OzellikGoster();


            #endregion

            #region get set
            // Özellik metotları GET ve SET anahtar kelimesinden oluşan iki kod bloğundan oluşurlar. GET metodu veri okunduğu zaman, SET metodu ise veri yazıldığı zaman(yani değer ataması yapıldığı zaman) yürütülür.Özellik olarak bu iki anahtar kelimeyi aynı anda kullanabildiğimiz gibi, tek anahtar kelime ile de oluşturabiliriz.



          //Urun urun = new Urun();

          //urun.UrunAd = "Domates";
          //urun.UrunNo = 1;
          //urun.Miktar = 100;
          //urun.AlisFiyat=10;


          //Console.WriteLine("Ürün No : {0}", urun.UrunNo);
          //Console.WriteLine("Ürün Adı : {0}",urun.UrunAd);
          //Console.WriteLine("Ürün Miktar : {0}", urun.Miktar);
          //Console.WriteLine("Alış Fiyatı : {0}", urun.AlisFiyat);
          //Console.WriteLine("Satış Fiyatı : {0}", urun.SatisFiyat);
          //Console.WriteLine("Kar : {0}", urun.Kar);


            #endregion

            #region enum : Numaralandırma türleri
          //Değişkenlerin alabileceği değerlerin sabit (belli) olduğu durumlarda programı daha okunabilir hale getirmek için kullanılır. Programda birçok değişkene tek tek sayısal değer vermek yerine "enum" kullanılabilir.

          PlakaList plaka = PlakaList.İstanbul;
            Console.WriteLine("Plaka No : {0}", plaka.ToString());

            int plakano = 34;

            PlakaList sehirad = (PlakaList)plakano;

            Console.WriteLine("Şehir Ad : {0}",sehirad);



            #endregion

            Console.ReadKey();
        }
    }

    class Programci
    {
        int yasi;
        string adi;
        string soyadi;
        string kullandigiDil;

        // Hic parametre almayan bir yapılandırıcı..
        public Programci()
        {
            this.adi = null;
            this.yasi = 0;
            this.soyadi = null;
            this.kullandigiDil = null;
        }

        // İsmini ve yasini alan bir yapılandırıcı..
        public Programci(int yasi, string adi)
        {
            this.adi = adi;
            this.yasi = yasi;

            this.soyadi = null;
            this.kullandigiDil = null;
        }


        // İsmini, soyismini ve yasini alan bir yapılandırıcı..
        public Programci(int yasi, string adi, string soyadi)
        {
            this.adi = adi;
            this.yasi = yasi;
            this.soyadi = soyadi;
            this.kullandigiDil = null;
        }

        // İsmini, soyismini kullandığı dili ve yasini alan bir yapılandırıcı..
        public Programci(int yasi, string adi, string soyadi, string kullandigiDil)
        {
            this.adi = adi;
            this.yasi = yasi;
            this.soyadi = soyadi;
            this.kullandigiDil = kullandigiDil;
        }

        public void OzellikGoster()
        {
            if (this.yasi != 0)
                Console.WriteLine("Yasi : " + this.yasi);
            else Console.WriteLine("Yasi bilgisi elimizde yok şu anda...");

            if (this.adi != null)
                Console.WriteLine("Adı : " + this.adi);
            else Console.WriteLine("Adi bilgisi elimizde yok şu anda...");

            if (this.soyadi != null)
                Console.WriteLine("Soyadı : " + this.soyadi);
            else Console.WriteLine("Soyadı bilgisi elimizde yok şu anda...");

            if (this.kullandigiDil != null)
                Console.WriteLine("Kullandığı Programlama dili : " + this.kullandigiDil);
            else Console.WriteLine("Hangi Dili kullanığını şu an için bilmiyoruz ... Göreceğiz :-(\n");
        }
    }

    class Urun
    {
        string urunad;

        public string UrunAd
        {
            get { return urunad; }
            set { urunad = value; }
        }
        
        int urunno;

        public int UrunNo
        {
            get { return urunno; }
            set { urunno = value; }
        }

        int miktar;

        public int Miktar
        {
            get { return miktar; }
            set { miktar = value; }
        }

        int alisfiyat;

        public int AlisFiyat
        {
            get { return alisfiyat; }
            set { alisfiyat = value; }
        }

        float satisfiyat;

        public float SatisFiyat
        {
            get { 
                    satisfiyat= (float)((float)alisfiyat * 1.1);
                    return satisfiyat; 
            }
            set { satisfiyat = value; }
        }

        public float Kar
        {
            get { return (float)miktar * (float)(satisfiyat - alisfiyat); }
        }

        public Urun()  //Kurucu metot
        {
            urunad = "";
            urunno = 0;
            miktar = 0;
            alisfiyat = 0;
            satisfiyat = 0;
        }
    }
}
