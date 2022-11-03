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

            #region Metot kullanımları

            EkranaYaz();

            Another.EkranaYaz2();

            EkranaYazPrm("Merhaba dünya...",5);

            int sonuc=Toplama(5);

            Console.WriteLine("\nToplam sonucu...{0}",sonuc);


            Console.WriteLine("\n2li çarpma sonucu = {0}\n", Carpma(4, 7));

            Console.WriteLine("\n3lü çarpma sonucu = {0}\n", Carpma(5,6,9 ));

            int[] dizi = { 12, 23, 1, 45, 6 };

            DiziyiYaz(dizi);

            //ref
            int i = 10;

            RefDeneme(ref i);

            Console.WriteLine(i);

            Console.ReadKey();



            #endregion
        }

        public static void EkranaYaz()
        {
            Console.WriteLine("Ben bir metodum.....\n");
        }

        #region Başka bir sınıf içinde kullanımı

        class Another
        {
            public static void EkranaYaz2()
            {
                Console.WriteLine("Ben bir metodum.....Ama başka bir sınıfın içinde.....\n");
            }
        }

        #endregion


        #region Parametreli-Geri dönüşsüz(void)

        public static void EkranaYazPrm(string metin,int adet)
        {
            for (int i = 1; i <= adet; i++)
            {
                Console.WriteLine("\nGelen parametre : {0}",metin);
            }
        }

        #endregion



        #region Parametreli-Geri dönüşlü

        public static int Topla(int sayi1,int sayi2)
        {

            return sayi1 + sayi2;
        }

        #endregion

        #region Default parametreli kullanım

        static int Toplama(int sayi1,int sayi2=30)
        {
            return sayi1 + sayi2;
        }

        #endregion
        
        #region Metot Overloading (Aşırı yüklenme)

        static int Carpma(int sayi1,int sayi2)
        {

            return sayi1 * sayi2;
        }

        static int Carpma(int sayi1, int sayi2, int sayi3)
        {

            return sayi1 * sayi2 * sayi3;
        }

        #endregion

        #region Dizilerin parametre olarak kullanılması


        static void DiziyiYaz(int[] prmdizi)
        {
            foreach (int i in prmdizi)
            {
                Console.WriteLine("Dizinin elemanı --> {0}", i);
            }
        }
        #endregion

        #region ref ve out sözcükleri-------------
        // ref anahtar sözcüğü ile metotlara parametre aktarabiliriz.Değer tipli bile olsalar referans olarak aktarılırlar

        static void RefDeneme(ref int deger)
        {
            deger = 100;
        }

        #endregion

    }
}
