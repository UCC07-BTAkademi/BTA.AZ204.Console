using System;

namespace Dikdortgen
{
    class Program
    {
        static void Main(string[] args)
        {
            int kisak, uzunk, alan, cevre;

            Console.Write("Kısa kenarı giriniz :");

            kisak = Convert.ToInt32(Console.ReadLine());

            Console.Write("Uzun kenarı giriniz :");

            uzunk = Convert.ToInt32(Console.ReadLine());


            alan = kisak * uzunk; // dikdörtgen alanı

            cevre = 2*(kisak + uzunk);


            Console.WriteLine("---------------");
            Console.WriteLine("Dikdörtgenin alanı : {0} , çevresi : {1} dır....",alan,cevre);
            Console.ReadKey();
        }
    }
}
