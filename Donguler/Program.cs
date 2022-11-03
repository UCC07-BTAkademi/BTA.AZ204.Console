using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanılan 4 tip döngü var
            // 
            // for, while, do while, foreach
            //


            // for döngüsü
            // 
            // for ( ifade1 ; ifade2 ; ifade3)
            //  deyimler
            // 
            // yada
            // for ( ifade1 ; ifade2 ; ifade3)
            // {
            //  deyim1;
            //  deyim2;
            //  deyim3;
            //  ....
            // }

            // Örnek : 1-10 arası sayıların toplamı--------------

            //int toplam = 0;

            //for (int i = 1; i <= 10; i++)
            //    toplam = toplam + i;

            //Console.WriteLine("\nSonuç : {0} ", toplam);


            // Örnek : Değişik bir yapı--------

            //int sayi = 0;
            //for (; sayi < 10; ++sayi)
            //    Console.WriteLine(sayi);


            // Örnek: 1den 500 e kadar olan sayılar içinde 3'e tam bölünen ve 5'e tam bölünemeyen sayıların adetlerini ve toplamlarını bulmak-----------------------

            //int adet = 0;
            //int top = 0;

            //for (int sayi = 0; sayi <= 200; sayi++)
            //{
            //    if ((sayi%3 == 0) && (sayi%5 != 0))
            //    {
            //        Console.WriteLine("Sayı : {0}", sayi);

            //        top += sayi;

            //        adet++;
            //    }
            //}

            //Console.WriteLine("\n\n{0} adet sayı bulundu..",adet);
            //Console.WriteLine("Toplamları={0} ", top);

            // Örnek : 0dan 100e kadar olan sayıları 5er 5er artışlı olacak şekilde bir satırda 6 adet sayı yazacak şekilde gösteriniz. Gösterilecek sayılar arasında da görünüm karmaşıklığı azaltmak için biraz boşluk veriniz.-------------

            //int satiradet = 0;

            //for (int sayi = 0; sayi <= 100; sayi+=5)
            //{
            //    if (satiradet % 6 == 0)
            //        Console.WriteLine();

            //    Console.Write("{0,3} ",sayi);

            //    satiradet++;

            //}

            //Console.WriteLine("\n\n");


            // Üçgen çizimi----------------------------------------

            //for (int i = 0; i < 5; i++) // Üçgenimizin kaç satırdan oluşacağını belirliyoruz.
            //{
            //    for (int k = 0; k < 5 - i; k++) // Üçgen yapımızın satırlarının oluşmasında belirli sayıda boşluk atılmasını sağlayan adım.
            //        Console.Write(" ");
            //    for (int j = 0; j <= i * 2; j++) // Üçgen yapımızı oluşturacak yıldızların belirli koşul yapısına bağlı olarak oluşmasını sağlayan döngü sistemi.
            //        Console.Write("*");
            //    Console.Write("  -> {0}. Üçgen Satırı\n", (i + 1));
            //}

            // =========================
            // while döngüsü
            //
            // while(kosul)
            //  deyim
            //
            // yada
            // 
            // while(kosul)
            // {
            //  deyim1;
            //  deyim2;
            //  deyim3;
            //  ....
            // }
            //

            // Örnek : 1 den 50 ye kadar olan sayıları yazdırma---------------------------------
            //

            //int sayi = 1;

            //while(sayi <= 50)
            //{
            //    Console.WriteLine("Sayı : {0} ", sayi);

            //    sayi++;
            //}

            // Örnek: 100e kadar olan pozitif tek tamsayıların toplamı---------------------------------

            //int sayi = 1;
            //int son = 100;
            //int toplam = 0;

            //while (sayi <= son)
            //{
            //    toplam += sayi;

            //    sayi += 2; 
            //}

            //Console.WriteLine("Pozitif tek sayiların toplamı : {0}", toplam);

            //===================================================
            // do while döngüsü
            //
            // do
            //  deyim
            // while (kosul);
            //
            // veya
            // 
            // do
            // {
            //  deyim1;
            //  deyim2;
            //  deyim3;
            //  ....
            // } while (kosul);

            // Örnek: şifre doğru olana kadar------------------------------

            //string sifre;

            //do
            //{
            //    Console.WriteLine("Şifrenizi giriniz :");

            //    sifre = Console.ReadLine();

            //} while (sifre != "q1w2e3");

            //Console.WriteLine("Doğru şifre");

            // Örnek: sayı tahmin oyunu----------------------------

            int tutdeger, girdeger, deneme = 1, toplamdeneme = 5;

            string ayrac = new string('-', 6);

            Random random = new Random();

            tutdeger = random.Next(10); // max 10a kadar random sayı üretir
            
            do
            {
                Console.Write("-> Lütfen Bir Tahminde Bulunun: ");

                girdeger = Convert.ToInt32(Console.ReadLine()); 
                
                if (tutdeger == girdeger)
                {
                    Console.Write("{0}\n-> Tebrikler. {1}.denemede doğru tahminde bulundunuz.\n{2}", ayrac, deneme, ayrac);
                    break;
                }
                else if (deneme == toplamdeneme)
                    Console.Write("{0}\n-> Üzgünüm deneme hakkınız bitti. Tahmin etmeniz gereken değer {1} olacaktı.\n{2}", ayrac, tutdeger, ayrac);
                else
                    Console.Write("{0}\n", ayrac);

                deneme++;

            } while (deneme <= toplamdeneme);



            Console.ReadKey();
        }
    }
}
