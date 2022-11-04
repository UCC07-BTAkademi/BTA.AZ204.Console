using System;

namespace AkisKontrol
{
    class Program
    {
        static void Main(string[] args)
        {

            // Üniv. Vize Final, Ortalama

            //int vizeNot, finalNot;
            //double ortalama;
            //string ayrac = "-------------------";

            //Console.WriteLine("Vize Notu : ");
            //vizeNot = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Final Notu : ");
            //finalNot = Convert.ToInt32(Console.ReadLine());

            //ortalama = (vizeNot * 0.4) + (finalNot * 0.6);


            //if (ortalama >= 88 && ortalama <= 100)
            //{
            //    Console.WriteLine("Ortalamanız : {0} ---> Harf olarak : AA", ortalama);
            //    Console.WriteLine(ayrac);
            //}
            //else if (ortalama >= 70 && ortalama <= 87)
            //{
            //    Console.WriteLine("Ortalamanız : {0} ---> Harf olarak : BA", ortalama);
            //    Console.WriteLine(new string('-', 20));
            //}
            //else
            //{
            //    Console.WriteLine("Ortalamanız : {0} ---> Harf olarak : BB", ortalama);
            //    Console.WriteLine(new string('-', 20));
            //}


            // Kullanıcıdan kullanıcı adı ve şifresi ekrandan alınacak
            // doğru olması durumunda br mesaj yazılacak
            // yanlış olması durumunda da ayrı bir mesaj yazılacaktır.

            //string kulad, kulsifre;

            //Console.WriteLine("Kullanıcı Ad :");
            //kulad = Console.ReadLine();
            //kulsifre = Console.ReadLine();

            //if (kulad == "ümit" && kulsifre == "2512")

            //    Console.WriteLine("OK");

            //else
            //    Console.WriteLine("Not OK");

            // çok basit bir dört işlem

            // iki adet sayı alınacak...küçük bir menüden de habgi işlemin yapılacağı alınacak.. ve sonuç hata mesajlarıyla birlikte yazılacak

            int sayi1, sayi2;
            string islem; // t toplama c çıkarma ç carpma b bolme olsun

            // do-while yapısı
            do
            {
                // aradaki işlemleri yap
                // Menu
                Console.WriteLine("Toplama : t");
                Console.WriteLine("Çıkarma : c");
                Console.WriteLine("Çarpma : ç");
                Console.WriteLine("Bölme : b");

                Console.WriteLine("Seçiminiz : (q-Çıkış)");

                islem = Console.ReadLine();

                Console.WriteLine("Sayi1 : ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayi2 : ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                #region çoklu if yapısı
                //if (islem == "b")
                //{
                //    if (sayi2 != 0) // sayı2nin 0 olup olmadığı kontrolu
                //    {
                //        float sonuc = (float)sayi1 / (float)sayi2;
                //        Console.WriteLine("Sayı1 in Sayı2 ye bölümü {0} dir", sonuc);
                //    }
                //    else
                //        Console.WriteLine("0 a bölüm olmaz");
                //}
                //else if (islem == "t")
                //    Console.WriteLine("Sayı1 ile sayı2nin toplamı {0} dır", sayi1 + sayi2);
                //else if (islem == "ç")
                //    Console.WriteLine("Sayı1 ile sayı2nin çarpımı {0} dır", sayi1 * sayi2);
                //else if (islem == "c")
                //    Console.WriteLine("Sayı1 ile sayı2nin farkı {0} dır", sayi1 - sayi2);
                #endregion

                // switch komutu

                switch (islem)
                {

                    case "t":
                        Console.WriteLine("Sayı1 ile sayı2nin toplamı {0} dır", sayi1 + sayi2);
                        break;

                    case "ç":
                        Console.WriteLine("Sayı1 ile sayı2nin çarpımı {0} dır", sayi1 * sayi2);
                        break;

                    case "c":
                        Console.WriteLine("Sayı1 ile sayı2nin farkı {0} dır", sayi1 - sayi2);
                        break;

                    case "b":
                        if (sayi2 != 0) // sayı2nin 0 olup olmadığı kontrolu
                        {
                            float sonuc = (float)sayi1 / (float)sayi2;
                            Console.WriteLine("Sayı1 in Sayı2 ye bölümü {0} dir", sonuc);
                        }
                        else
                            Console.WriteLine("0 a bölüm olmaz");
                        break;


                }




            } while (islem !="q"); // buradaki kontrol doğru olana kadar.






                Console.ReadKey();











        }
    }
}
