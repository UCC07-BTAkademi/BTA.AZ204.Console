using System;

namespace Degisgenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Öncelikle değişgenlerimi tanımlıyorum

            #region Degisgenler
            // Değişgenlerin bulunduğu bölüm

            string vsAd;
            string vsSoyad;
            int viYas;




            #endregion


            Console.Write("Lütfen adınızı giriniz : ");

            vsAd = Console.ReadLine(); // Konsoldan girileni oku Ad bilgisi

            Console.Write("Lütfen soyadınızı giriniz : ");

            vsSoyad = Console.ReadLine(); // Konsoldan girileni oku Soyad bilgisi

            Console.Write("Lütfen yaşınızı giriniz : ");

            viYas = Convert.ToInt32(Console.ReadLine()); // Konsoldan girileni oku Soyad bilgisi


            Console.WriteLine("Merhaba " + vsAd + " " + vsSoyad + " .... Yaşınız : " + viYas.ToString() + "....Teşekkür ederiz....");

            Console.ReadKey();


        }
    }
}
