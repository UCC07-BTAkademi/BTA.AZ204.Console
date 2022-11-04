using System;


// Kullanıcı klavyeden sayı girişi yapabilmektedir. Girdiği sayıların toplamı 50'den büyük olduğunda ekrana o ana kadar girilen sayı adedini ve sonucu yazan bir programcık
namespace WO_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayi; // girilen sayı
            int sayac = 0; // dongüden çıkıldığındaki kac tane sayı girildiğini tutan değişgen

            while (toplam < 50)
            {
                Console.Write("Sayınızı giriniz : ");

                sayi = Convert.ToInt32(Console.ReadLine());

                toplam = toplam + sayi; // toplam += sayi;

                sayac = sayac + 1; // sayac++;
            }

            Console.WriteLine($" {sayac} adet sayı girdiniz....Bunların toplamı : {toplam} dır...");

            Console.ReadKey();
        }
    }
}
