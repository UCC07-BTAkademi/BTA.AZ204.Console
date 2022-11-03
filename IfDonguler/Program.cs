using System;

namespace IfDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // if yapısı
            // Değişken Tanımlaması:
            int vizeNotu, finalNotu;
            double ortalama;
            // Notları Kullanıcıdan Alma:
            Console.Write(new string('-', 20) + "\n-> Vize Notunu Girin: ");
            vizeNotu = Convert.ToInt32(Console.ReadLine());
            Console.Write("-> Final Notunu Girin: ");
            finalNotu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 20));
            ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6);
            if (ortalama >= 88 && ortalama <= 100)
            {
                Console.WriteLine("-> Ortalamanız: {0} \n-> Harf Notunuz: AA", ortalama);
                Console.WriteLine(new string('-', 20));
            }
            else if (ortalama >= 70 && ortalama <= 87)
            {
                Console.WriteLine("-> Ortalamanız: {0} \n-> Harf Notunuz: BA", ortalama);
                Console.WriteLine(new string('-', 20));
            }
            else
            {
                Console.WriteLine("-> Ortalamanız: {0} \n-> Harf Notunuz: BB", ortalama);
                Console.WriteLine(new string('-', 20));
            }


            //Switch

            //int gun = (int)DateTime.Now.DayOfWeek;
            //switch (gun)
            //{
            //    case 1:
            //        Console.Write("Bugün Pazartesi");
            //        break;
            //    case 2:
            //        Console.Write("Bugün Salı");
            //        break;
            //    case 3:
            //        Console.Write("Bugün Çarşamba");
            //        break;
            //    case 4:
            //        Console.Write("Bugün Perşembe");
            //        break;
            //    case 5:
            //        Console.Write("Bugün Cuma");
            //        break;
            //    case 6:
            //        Console.Write("Bugün Cumartesi");
            //        break;
            //    case 7:
            //        Console.Write("Bugün Pazar");
            //        break;
            //}










            // Üçgen çizimi
            //for (int i = 0; i < 5; i++) // Üçgenimizin kaç satırdan oluşacağını belirliyoruz.
            //{
            //    for (int k = 0; k < 5 - i; k++) // Üçgen yapımızın satırlarının oluşmasında belirli sayıda boşluk atılmasını sağlayan adım.
            //        Console.Write(" ");
            //    for (int j = 0; j <= i * 2; j++) // Üçgen yapımızı oluşturacak yıldızların belirli koşul yapısına bağlı olarak oluşmasını sağlayan döngü sistemi.
            //        Console.Write("*");
            //    Console.Write("  -> {0}. Üçgen Satırı\n", (i + 1));
            //}


            // While

            //int max, min = 1, sum = 0, totalValue = 0;
            //string mark = new string('-', 6);
            //Console.WriteLine("{0}\n< C# While Döngüsü Örnekleri #1 >\n{1}", mark, mark);
            //Console.Write("-> Kontrol edeceğiniz bir tam sayı girişi yapın: ");
            //max = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(mark);
            //while (min <= max)
            //{
            //    if (max % min == 0)
            //    {
            //        Console.WriteLine("-> [{0}] sayısı [{1}] değerine tam bölünür.", max, min);
            //        totalValue += min;
            //        sum += 1;
            //    }
            //    if (min == max)
            //        Console.WriteLine("{0}\n-> İşlem sonucunda [{1}] sayısı {2} kere tam bölündü.\n-> Bu değerlerin toplamı: {3}\n{4}", mark, max, sum, totalValue, mark);
            //    min++;
            //}


            Console.ReadKey();
        }
    }
}
