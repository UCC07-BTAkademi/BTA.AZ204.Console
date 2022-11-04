using System;

// Kullanıcı klavyeden 0 değeri girinceye kadar okunan sayıların toplamı ve ortalamasını bulan programcık.

namespace WO_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayınızı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi;

            int sayac = 1;

            while (sayi != 0)
            {
                Console.Write("Sayınızı giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());

                toplam += sayi;

                if (sayi != 0)  // ortalama işlemine(sayac) adetsel olarak 0 değerini sokmamak için...
                {
                    sayac++;
                }

            }

            Console.WriteLine("Girilen sayıların toplamı = {0} , Ortalaması = {1}",toplam, toplam / sayac);





            Console.ReadKey();
        }
    }
}
