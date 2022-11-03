using System;

namespace Siniflar2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class içinde class tanımlandığı classın bir elemanımıdır
            // Classın tanımlanabildiği yerler...
            // Sınıf elemanı nedir

            //MyClass myc1 = new MyClass();


            //MyClass.MyClass2 myc2 = new MyClass.MyClass2();

            #endregion

            #region Class elemanlarına açıklama satırı eklemek

            Random random = new Random();


            #endregion

            #region this keywordu
            // 1. Sınıfın nesnesini temsil eder ...genelde bunun için kullanılır

            MyClass myc1 = new MyClass();

            myc1.Yaz("fffffff");

            Console.WriteLine(myc1.ad);

            MyClass myc2 = new MyClass();

            // 2. Aynı isimdeki field ve metot ları ayırmak için kullanılır


            // 3. Bir constructor dan başka bir constructor çağırmak için kullanılır



            #endregion


            //#region Get - Set anahtar sözcükleri
            //// alanları özel olarak tanımlamanız ve ardından get ve set erişimcileriyle değerlerine genel bir şekilde erişmek için özellikleri kullanmanız gerekir.

            #region Örnekler

            //// Personel örneği

            Personel.PersonelSayisi = 100;

            Personel prsnl = new Personel();

            prsnl.Isim = "Ümit Karaçivi";

            Console.WriteLine("Personel Sayısı: {0}", Personel.PersonelSayisi);
            Console.WriteLine($"Personel Adı : {prsnl.Isim}");
            ////Çıktı: 101

            //Console.WriteLine("Personel Ismi: {0}", prsnl.Isim);
            ////Çıktı: Ümit Karaçivi


            //// Urun örneği
            //Urun urn = new Urun();

            //urn.UrunAd = "Kursun Kalem";
            //urn.UrunKod = "KK";
            //urn.UrunFyt = 10.786;

            //Console.WriteLine("Ürün Adı: {0} - Ürün Kodu: {1} - Ürün Fiyatı: {2}", urn.UrunAd, urn.UrunKod, urn.UrunFyt);
            ////ÇIKTI: Ürün Adı: Kursun Kalem
            ////ÇIKTI: Ürün Kodu: KK918
            ////ÇIKTI: Ürün Fiyat: 10.8



            //#endregion


            #region Constructor kullanımı

            Programci a = new Programci();
            Programci b = new Programci(23, "Barış");
            Programci c = new Programci(27, "Metin", "Yazılımcı");
            Programci d = new Programci(58, "Ümit", "Karaçivi", "C#");


            a.OzellikGoster();
            b.OzellikGoster();
            c.OzellikGoster();
            d.OzellikGoster();

            #endregion



            #endregion

            Console.ReadLine();

        }
    }


    /// <summary>
    /// Örnek sınıf
    /// </summary>
    class MyClass
    {


        /// <summary>
        /// Örnek field
        /// </summary>
        public int a; // field
        public string ad; // 2.kullanım için

        /// <summary>
        /// Örnek property
        /// </summary>
        public int MyProperty { get; set; } // Property

        /// <summary>
        /// Örnek metot
        /// </summary>
        public void Yaz() // metot
        {
            this.Yaz(); // sınıfın bu metodu çağrıldığında recursive olacak. this o anki nesneyi temsil edecek.

        }

        /// <summary>
        /// Örnek metot (overload)
        /// </summary>
        /// <param name="ad">ad parametresi</param>
        public void Yaz(string ad)
        {
            ad="aa";
            this.ad = "bb";
        }

        public class MyClass2  // Classın elemanı olmuyor
        {

        }


    }

    // get set için
    class Personel
    {
        public static int PersonelSayisi;
        private static int say;
        private string isim;

        // Okuma ve Yazma Özelliği
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        // Sadece Okunabilir Özelliği
        public static int Say
        {
            get { return say; }
        }

        // Yapıcı metodumuz.
        public Personel()
        {
            // Personel Sayısını Hesapla
            say = PersonelSayisi++;
        }
    }

    class Urun
    {
        private string urunad;
        private string urunkod;
        private double urunfyt;

        //Değer alıp gönderen metodumuz.
        public string UrunAd
        {
            get { return urunad; }
            set { urunad = value; }
        }
        //100-999 arasında değer üretip kullanıcıdan alınan değerle birleştirip  ürün kodu set ediyoruz
        public string UrunKod
        {
            get { return urunkod; }
            set
            {
                Random rnd = new Random();
                urunkod = value.ToString() + rnd.Next(100, 999).ToString();
            }
        }
        //Kullanıcıdan alınan veriyi yuvarlayıp set ediyoruz.
        public double UrunFyt
        {
            get { return urunfyt; }
            set
            {
                urunfyt = Math.Round(value, 1);
            }
        }
    }

    class Kisi
    {
        private string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
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
}

