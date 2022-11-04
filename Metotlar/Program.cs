using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metot Nedir?

            // Yapılması istenen program adımlarının ayrı bir kod bloğu içersinde tanımlanıp ve bu bloğa bir isimlendirme yapılarak
            // oluşturulan yapılardır. Programınızın herhangi bir yerinde ihtiyaç duyduğunuzda bu oluşturmuş olduğunuz kod bloğunu
            // ismi ile çağırıp kullanabilirsiniz. (DRY : Don't Repeat Yourself)

            // Metot tanımlama syntax'ı
            //
            // <metot erişim belirteci> <geri dönüş tipi> <metot ismi> (<metot parametreleri>)
            // { }
            //
            // <metot erişim belirteci>
            // private : Yanlızca metotun yazılmış olduğu sınıfta kullanılabilir.
            //
            // public : Tüm program dahilinde kullanılabilir.
            //
            // static : private ve public den sonra eklendiğinde metot doğrudan kullanılabilir.Eğer eklenilmezse bulunduğu sınıftan
            // bir nesne yaratılarak kullanılabilir

            // <geri dönüş tipi>
            // Eğer metot herhangi bir geridönüş işlemi yapmayacaksa buraya "void" yazılır. Eğer bir değer dönecekse
            // bu değerin tipi belirtilir

            // <metot ismi>
            // Anlamlı olacak şekilde yazılan metota verilen ismi belirtir

            // <metot parametreleri>
            // Metoda dışardan değer gönderilmeyecekse () lerin içi boş bırakılır. Eğer gönderilecekse gönderilecek değişgenler
            // aralarında virgül konarak belirtilir (string ad,int yas) gibi

            // . Metotların isimlendirilmesinde genel C# notasyonuna göre olması
            // . Parametreli kullanımlarda parametrelerin eksiksiz olarak girilmesi gerekiyor.
            // . Özellikle geridönşlü metotlarda tiplere dikkat edilmesi gerekiyor. Değişgen atamalarında uyumlu tiplerde değişgen tanımlamaları yapılmalıdır.
            // . void ile tanımlanmış bir metotda return ifadesi bulunmamalıdır.
            // . Parametre gönderilmeyecek metotları çağırırken parametre içeriği boş bırakılır.
            //  .Tanımlnan metot parametrelerinin tekrardan metot içerinde tanımlaması yapılmaz.





            Program prg = new Program(); // Örnekleme yaparak altındaki static belirtilmeyen metotlara erişim için.

            
            prg.EkranaYaz();

            //EkranaYaz();

            //Another.EkranaYaz2();  // başka bir sınıftan olan metodu kullanma...

            //EkranaYazPrm("Merhaba insanlık......", 5);

            //Console.WriteLine("Sonuç : {0}", Topla(4, 7));

            //int sonuc = Toplama(5);

            //Console.WriteLine("\nSonuç ... : {0}", sonuc);

            //Console.WriteLine("\n2li çarpma sonucu = {0}", Carpma(4, 6));

            //Console.WriteLine("\n3lü çarpma sonucu = {0}", Carpma(5, 8, 2));

            //int[] dizi = { 12, 34, 54, 23, 78 };

            //DiziyiYaz(dizi);

            //int deger = 40;

            //RefDeneme(out deger);

            //Console.WriteLine("\nDeğer ... {0}", deger);

            //Console.WriteLine(Faktoriyel(0));
            //Console.WriteLine(Faktoriyel(4));
            //Console.WriteLine(Faktoriyel(10));

            MathYaz(Math.Min(7,9));
            MathYaz(Math.Abs(-10));
            MathYaz(Math.Cos(60));
            MathYaz(Math.Sqrt(144));


            Console.ReadKey();
        }


        #region Örnek Metotlar1

        public void EkranaYaz()
        {

        //Console.WriteLine("Ben bir metodum.......");

        }

        #endregion

        #region Parametreli ve geri dönüşsüz bir metot (void)

        public static void EkranaYazPrm(string metin,int adet)
        {
            for (int i = 1; i <= adet; i++)
            {
                Console.WriteLine("\nGelen metin değeri : {0}",metin);
            }
        }

        #endregion

        #region Parametreli ve geri dönüşlü bir metot

        public static int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        #endregion

        #region Default prametreli kullanımı

        public static int Toplama(int sayi1,int sayi2 = 30)
        {

            return (sayi1 + sayi2);
        }


        #endregion

        #region Metot aşırı yüklenmesi (Method Overloading)

        static int Carpma(int sayi1, int sayi2) // Metot signature (metot imzası)
        {
            return (sayi1 * sayi2);
        }

        static int Carpma(int sayi1, int sayi2,int sayi3) // Metot signature (metot imzası)
        {
            return (sayi1 * sayi2*sayi3);
        }



        #endregion

        #region Metotlarda dizilerin parametre olarak kullanımı
        static void DiziyiYaz(int[] prmdizi)
        {
            foreach (int i in prmdizi)
            {
                Console.WriteLine("\nDizinin elemanı ---> {0}", i);
            }

        }

        #endregion

        #region ref ve out anahtar sözcükleri ???????

        static void RefDeneme (out int deger)
        {
            deger = 100;

        }


        #endregion

        #region Metotların kendini çağırması (recursive methods)
        // 6!
        static int Faktoriyel(int sayi)
        {
            if (sayi==0)
            {
                return 1; // 0 fakt=1
            }
            else
            { 
                return sayi * Faktoriyel(sayi - 1);
            
            }

        }

        #endregion

        #region Math sınıfı metotları

        static void MathYaz(object o)
        {

            Console.WriteLine(o.ToString());
        }

        #endregion



        class Another
        {
            public static void EkranaYaz2()
            {
                Console.WriteLine("Ben bir metodum.....Ama şu an başka bir sınıfın içindeyim....\n");
            }
        }
    }
}
