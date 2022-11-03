using System;

// Öğrenci geçiş ortalaması
namespace Notlar
{
    class Program
    {
        static void Main(string[] args)
        {
            float not1,not2,not3;
            float ortalama;

            Console.Write("1.Not :");

            not1 = Convert.ToInt32(Console.ReadLine());

            if (not1 > 100 && not1 < 0 )
            {
                Console.WriteLine("Yanlış değer");
            }

            Console.Write("2.Not :");

            not2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("3.Not :");

            not3 = Convert.ToInt32(Console.ReadLine());

            ortalama = (not1 + not2 + not3) / 3;

            if (ortalama >= 50 )
            {
                // doğruysa
                Console.WriteLine("Geçtiniz..tebrikler..Ortalamanız : {0} ", ortalama.ToString());

            }
            else
            {
                // yanlışsa
                Console.WriteLine("Maalesef bir daha deneyiniz..Ortalamanız : {0} ", ortalama.ToString());

            }

            Console.ReadKey();
        }
    }
}
