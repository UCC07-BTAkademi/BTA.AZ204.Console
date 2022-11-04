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

            #region Örnek1
            // Örnek 1 : 1-20 arasındaki sayıların toplamı

            //int toplam = 0;

            //for (int sayi = 1 ; sayi <= 20 ; sayi++)
            //{
            //    toplam = toplam + sayi;
            //}


            //Console.WriteLine("\nSonuç : {0}",toplam);
            #endregion

            #region Örnek2
            // Örnek 2: Değişik yapıda

            //int sayi = 0;

            //for (; sayi < 10; sayi++)
            //{
            //    Console.WriteLine("Sayı : {0}", sayi);
            //}
            #endregion

            #region Örnek3
            // Örnek3: 1den 200 e kadar olan sayılar içinde 3'e tam bölünen ve 5'e tam bölünemeyen sayıların adetlerini ve toplamlarını bulmak-----------------------

            //int adet = 0; // kac tane old. tutacağım
            //int toplam = 0;

            //for (int sayi = 1; sayi <= 200; sayi++)
            //{
            //    if ((sayi % 3 == 0) && (sayi % 5 != 0)) 
            //    {
            //        // ilgili sarta uyan sayı bulundu
            //        Console.WriteLine("Sayı : {0}", sayi);

            //        toplam = toplam + sayi;

            //        adet = adet + 1; ;

            //    }
            //}

            //Console.WriteLine("\n\n {0} adet sayı bulundu.....", adet);
            //Console.WriteLine("\nToplamları : {0}", toplam);
            #endregion

            #region Örnek4
            // 0dan 100e kadar olan sayıları 5er 5er artışlı olacak şekilde ve bir satırda 6 adet sayı yazacak şekilde gösteriniz.Gösterilecek sayılar arasında da görünüm karmaşıklığı azaltmak için biraz boşluk veriniz.
            // a b c d e f
            // g h i j k l
            // .....

            //int satiradet = 0; //satırda yazılacak eleman sayısı

            //for (int sayi = 0; sayi <= 100 ; sayi += 5)
            //{
            //    if (satiradet % 6 == 0) // demekki bir satırı doldurmuşum ..bir alt satıra yazmaya devam edebilirim..
            //    {
            //        Console.WriteLine();
            //    }

            //    Console.Write("{0,3} ",sayi); // db

            //    satiradet++;
            //}

            //Console.WriteLine("\n\nBitti");
            #endregion

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

            #region Örnek5
            // Örnek : 1 den 50 ye kadar olan sayıları yazdırma---------------------------------

            //int sayi = 1;

            //while (sayi <=50)
            //{
            //    Console.WriteLine("Sayi : {0}", sayi);

            //    sayi++;

            //}

            #endregion

            #region Örnek6
            // Örnek: 100e kadar olan pozitif tek tamsayıların toplamı

            //int sayi = 1;
            //int sonsayi = 100;
            //int toplam = 0;

            //while (sayi <= sonsayi)
            //{
            //    toplam = toplam + sayi;

            //    sayi = sayi + 2;

            //}
            //Console.WriteLine("Pozitif tek sayıların  toplamı : {0}", toplam);

            #endregion

            //-------------------------
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

            #region Örnek7
            // Örnek: şifre doğru olana kadar-------

            //string sifre;

            //do
            //{
            //    Console.Write("Şifrenizi giriniz : ");

            //    sifre = Console.ReadLine();

            //    sifre = sifre.Trim(); // girilen string değerin baş - sondaki eğer girilmişse boşluk karakterlerini atar kırpar....

            //} while (sifre != "q1w2e3");

            //Console.WriteLine("Doğru şifreyi girdiniz....");

            #endregion


            #region Örnek8
            // sayı tahmin oyunu...

            int tutdeger, girdeger, deneme = 1, toplamdeneme = 10;

            string ayrac = "-----";
            //string ayrac = new string('-', 15);

            Random random = new Random(); // daha sonra bakılacak


            tutdeger = random.Next(10); // 0 ila 10 arasında bir sayı tutacak

            do
            {
                Console.WriteLine("Lütfen sayınızı giriniz    : ");

                girdeger = int.Parse(Console.ReadLine());

                if (tutdeger == girdeger)
                {
                    Console.WriteLine("{0}\nTebrikler...{1}.denemede bildiniz...\n{2}", ayrac, deneme, ayrac);
                    break;
                }
                else if (deneme == toplamdeneme)
                    Console.WriteLine("{0}\n-> Üzgünüm deneme hakkınız bitti. Tahmin etmeniz gereken değer {1} olacaktı.\n{2}", ayrac, tutdeger, ayrac);

                else
                    Console.WriteLine("{0}\n", ayrac);

                deneme++;

            } while (deneme <= toplamdeneme);


            #endregion

            Console.ReadKey();
        }
    }
}
