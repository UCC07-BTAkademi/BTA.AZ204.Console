using System;

namespace Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;

            Console.Write("1.Sayınız : ");

            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2.Sayınız : ");

            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;

            Console.WriteLine("{0} ve {1} sayılarının toplamı = {2}",sayi1,sayi2,toplam);

            Console.ReadKey();
        }
    }
}
