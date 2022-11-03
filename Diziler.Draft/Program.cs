using System;

namespace Diziler.Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diziler
            // En basit tanımıyla dizi, aynı tipte birden çok değeri bellek üzerinde tutabilecek yapıdır.

            // Dizi tanımlanması
            //
            // Dizi oluştururken temelde üç noktaya dikkat edilir...

            // Dizi tipi : int, string, char, byte, double vb.
            // Dizi adi : Dizide saklanacak verilerle anlamlandırılan değişken isimlendirme kurallarına uygun bir ad
            // Dizi kapasitesi : Dizi içinde kaç adet veri saklanacağı belirtilir.


            string[] isimler = new string[5]; // String tipinde 5 elemanlı dizidir.
            byte[] siralar = new byte[6]; // Byte tipinde 6 elemanlı dizidir.
            bool[] durumlar = new bool[4]; // Boolean tipinde 4 elemanlı dizidir.
            float[] uzunluklar = new float[8]; // Float tipinde 8 elemanlı dizidir.

            // Tek boyutlu bir diziye değer aktarma---Birkaç farklı yöntemle yapılabilir

            string[] sehirler = new string[5] {"İstanbul","Ankara","İzmir","Bursa","Adana"};

            int[] sayilar = new int[6]; // Int tipinde 6 elemanlı bir dizi.            
            sayilar[0] = 10; //sayilar dizisinin 0 index numaralı elemanı 10 oldu.
            sayilar[1] = 25; //sayilar dizisinin 1 index numaralı elemanı 25 oldu.
            sayilar[2] = 45; //sayilar dizisinin 2 index numaralı elemanı 45 oldu.
            sayilar[3] = 5; //sayilar dizisinin 3 index numaralı elemanı 5 oldu.
            sayilar[4] = -30; //sayilar dizisinin 4 index numaralı elemanı -30 oldu.
            sayilar[5] = -50; //sayilar dizisinin 5 index numaralı elemanı -50 oldu.

            // Örnek

            //int eleman;
            //string ad;
            //string[] adlar = new string[5];

            //eleman = 0;

            //do
            //{
            //    Console.Write("Ad giriniz : ");
            //    ad = Console.ReadLine();

            //    adlar[eleman] = ad;
            //    eleman++;
            //    Console.WriteLine();

            //} while (eleman <= adlar.Length-1); // dizi indexi 0 dan başladığı için

            //Console.WriteLine("Giriş işlemi bitti....");
            //Console.WriteLine("\nDiziyi yazdırmak için bir tuşa basınız....");
            //Console.ReadKey();

            //foreach (string addegeri in adlar)
            //{
            //    Console.WriteLine("Ad değeri = {0}", addegeri);
            //}

            //======================================================================
            // Örnek : Dizi sıralama

            //// Ayraç Değişkeni:
            //string ayrac = new string('-', 20);
            //// Random Değerler Üreteceğimiz Dizi :
            //int[] randomDegerler = new int[5];
            //// Diziye Random Değerler Ataması Gerçekleştirelim:
            //Random random = new Random();

            //for (int i = 0; i < randomDegerler.Length; i++)
            //{
            //    int randomSayi = random.Next(1, 100); // 1'ile 100 arasında random değerler üretecek.
            //    randomDegerler[i] = randomSayi;
            //    Console.WriteLine("-> [{0}] İndise Atanan Değer: {1}", i, randomDegerler[i]);
            //}
            //// Küçükten Büyüğe Sıralama İşlemi Yapalım:
            //Array.Sort(randomDegerler); // Küçükten Büyüğe Sıralanma İşlemi Tamamlandı.

            //for (int k = 0; k < randomDegerler.Length; k++)
            //    Console.WriteLine("-> [{0}] İndise Gelen Değer: {1}", k, randomDegerler[k]);
            //Console.WriteLine(ayrac);

            //Array.Reverse(randomDegerler);
            //Console.WriteLine("{0}\n< Sıralanan Değerler >\n{1}", ayrac, ayrac);
            //for (int k = 0; k < randomDegerler.Length; k++)
            //    Console.WriteLine("-> [{0}] İndise Gelen Değer: {1}", k, randomDegerler[k]);
            //Console.WriteLine(ayrac);

            //==================================================================
            // Örnek : Dizi karşılaştırma

            //string[] karakterler1 = { "A", "C", "Ö", "O", "M", "N" };

            //string[] karakterler2 = { "A", "C", "Ö", "O", "M", "N" };

            //// Dizilerin Eşitliğini Kontrol Ettirelim:
            //if (Array.Equals(karakterler1, karakterler2) == true)
            //    Console.WriteLine("Tanımlamış Olduğunuz Dizilerin Elemanları Birbirine Eşittir.");
            //else
            //    Console.WriteLine("Tanımlamış Olduğunuz Dizilerin Elemanları Birbirine Eşit Değildir.");

            //========================================
            // Örnek : Random dizi oluşturma

            // Dizi Tanımlaması:
            //int[] randomDizi = new int[10];
            //// Random Değerleri Oluşturma İşlemi:
            //Random random = new Random();
            //int randomDeger; // Oluşan random değerleri tutacak değişken.

            //for (int i = 0; i < randomDizi.Length; i++)
            //{
            //    randomDeger = random.Next(100);
            //    randomDizi[i] = randomDeger;
            //    Console.Write("[{0}] ", randomDizi[i]);
            //}

            //Console.WriteLine();

            //=========================================
            // Örnek : Dizi içerisinde arama yapma (Array.Find)

            //string[] adlar = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };

            //string bulunacakad = "Bill";

            //string result = Array.Find(adlar, element => element == bulunacakad);
            
            //    Console.WriteLine(result);
            
            //string result1 = Array.Find(adlar, element => element.StartsWith("B"));
            
            //    Console.WriteLine(result1);

            //string result2 = Array.Find(adlar, element => element.Length>=5);

            //    Console.WriteLine(result2);

            //// Çoklu bulma : FindAll
            //string[] result3 = Array.FindAll(adlar, element => element.StartsWith("B"));

            //foreach (string sonuc in result3)
            //{
            //    Console.WriteLine("Ad değeri = {0}", sonuc);
            //}

            //string[] result4 = Array.FindAll(adlar, element => element.Length >= 5);
            //foreach (string sonuc in result4)
            //{
            //    Console.WriteLine("Ad değeri = {0}", sonuc);
            //}


            //===========================================================================
            // Çok boyutlu diziler
            // Çok boyutlu bir dizide dizinin her elemanı aynı zamanda bir dizidir.

            // int[ , ] dizi = { { 1, 2 ,3}, { 3, 4, 5 } };
            // int [ , ] dizi = new int[2, 3]{ {1, 2, 3}, {3, 4, 5} };
            //
            // Dizinin ilk elemanına erişim
            // dizi[0, 0];  // 1

            // ikinci satırın üçüncü elemanına erişim
            // dizi[1, 2];  // 5

            // birinci satırın 3. elamanına erişim
            // dizi[0, 2];  // 3

            // =======================================================================
            // Örnek : random sayılarla multi dizi oluşturma

            Console.Write("Satır sayısını giriniz : ");
            int satir = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Sütun sayısını giriniz : ");
            int sutun = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("===============================");
            
            Random rnd = new Random();

            int[,] dizi2 = new int[satir, sutun];
            
            for (int sat = 0; sat < satir; sat++)
            {
                for (int sut = 0; sut < sutun; sut++)
                {
                    dizi2[sat, sut] = rnd.Next(0, 50);

                    Console.Write(dizi2[sat, sut] + "-");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
