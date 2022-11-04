using System;

namespace WorkOut01
{
    class Program
    {

        static void Oyun()
        {
            int sayi1, sayi2, sonuc, kullanicicevabı, dogrusayisi = 0, yanlıssayisi = 0, puan = 0;


            Random random = new Random();



            for (int i = 1; i <= 10; i++)
            {
                sayi1 = random.Next(1, 100);
                sayi2 = random.Next(1, 100);
                sonuc = sayi1 + sayi2;

                Console.WriteLine("Aşağıda verilen sayıların toplamını yazınız:");
                Console.WriteLine(sayi1 + "+" + sayi2 + "= ");
                kullanicicevabı = Convert.ToInt32(Console.ReadLine());

                if (kullanicicevabı == sonuc)
                {
                    Console.WriteLine("Tebrikler Bildiniz");
                    dogrusayisi++;
                    puan = (dogrusayisi * 5) - (yanlıssayisi * 2);
                    Console.WriteLine("puanınız:" + puan);
                    Console.WriteLine("    ");
                }
                else
                {
                    Console.WriteLine("üzgünüm Bilemediniz");
                    yanlıssayisi++;
                    puan = ((dogrusayisi * 5) - (yanlıssayisi * 2));
                    Console.WriteLine("puanınız:" + puan);
                    Console.WriteLine("    ");
                }

            }

            Console.WriteLine("    ");
            Console.WriteLine("Doğru cevap sayınız:" + dogrusayisi);
            Console.WriteLine("Yanlış cevap sayınız:" + yanlıssayisi);
            Console.WriteLine("puanınız:" + puan);


            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            // 
            //1. Ekrandan alınan bir karakter katarını Alfabetik sıralı olarak yazan bir program yazınız. İpucu : Ekrandan alınan karakter katarının herbir elemanına sanki bir dizi elemanına ulaşıyormuş gibi ulaşabilirsiniz

            //Console.Write("Bir Kelime Giriniz : ");

            //string isim = Convert.ToString(Console.ReadLine());

            //int uzunluk = isim.Length;

            //char[] dizi = new char[uzunluk];

            //string sirali = "Alfabetik Sıra İle Dizilişi :";

            //for (int i = 0; i < uzunluk; i++)

            //{

            //    dizi[i] = isim[i];

            //}

            //Array.Sort(dizi);

            //for (int i = 0; i < uzunluk; i++)

            //{

            //    sirali += dizi[i];

            //}

            //Console.WriteLine(sirali);


            // ==============================================
            //2 . Toplama işlemini öğretmeye çalışan bir oyun programı yazılacaktır. Oyun başladığı zaman rastgele 2 tane 1 - 100 arasında sayı tutulacak, tutulan sayılar ekrana gösterilecek ve kullanıcıya bu sayıların toplamı nedir diye sorulacaktır. Eğer kullanıcı doğru cevap verirse “Tebrikler Bildiniz” değil ise “Üzgünüm Bilemediniz” diye mesaj verecektir.Her cevaptan sonra “Tekrar Oynamak istiyormusunuz(e / E) ?” şeklinde bir soru sorulacak ve eğer kullanıcı “e” veya “E” ile karşılık verirse oyun tekrar başlayacaktır. Kullanıcının puanı her doğru cevap için 5 puan artacak, her yanlış cevap için ise 2 puan azalacaktır. Oyun sonlandığında kullanıcının verdiği doğru cevap sayısı, yanlış cevap sayısı ve puanı ekranda listelenmelidir.Bu işlemleri yapan programın kodlarını yazınız.

            //Random rnd = new Random();
            //int ilkSayi = 0, ikinciSayi = 0, toplamPuan = 0, sayilarinToplami = 0, girilenCevap = 0, dogruCevapSayisi = 0, yanlisCevapSayisi = 0;
            //char devam;
            //do
            //{

            //    ilkSayi = rnd.Next(1, 100);
            //    ikinciSayi = rnd.Next(1, 100);
            //    sayilarinToplami = ilkSayi + ikinciSayi;
            //    Console.WriteLine("{0} + {1} = ?", ilkSayi, ikinciSayi);
            //    Console.Write("Cevabınız : ");
            //    girilenCevap = Convert.ToInt32(Console.ReadLine());
            //    if (girilenCevap == sayilarinToplami)
            //    {
            //        Console.WriteLine("Tebrikler Bildiniz");
            //        toplamPuan += 5;
            //        dogruCevapSayisi += 1;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Üzgünüm Bilemediniz");
            //        toplamPuan -= 2;
            //        yanlisCevapSayisi += 1;
            //    }
            //    Console.Write("Tekrar Oynamak istiyormusunuz(e/E)?");
            //    devam = Convert.ToChar(Console.ReadLine());

            //} while (devam == 'E' || devam == 'e');

            //Console.WriteLine("Toplam Doğru Cevap Sayınız {0}, Yanlış Cevap Sayınız {1}, Toplamda Almış Olduğunuz Puan {2}", dogruCevapSayisi, yanlisCevapSayisi, toplamPuan);

            //========================================
            char kullanici;

            Console.WriteLine("Oyuna başlayabilirsiniz...");
            Console.WriteLine("    ");
            System.Threading.Thread.Sleep(3000);
            Program.Oyun();

            while (true)
            {

                Console.WriteLine("    ");
                Console.WriteLine("Tekrar oynamak ister misiniz?");
                kullanici = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("    ");

                if (kullanici == 'e' || kullanici == 'E')
                {
                    Console.WriteLine("Yeni oyuna başlayabilirsiniz");
                    Console.WriteLine("    ");
                    System.Threading.Thread.Sleep(3000);
                    Program.Oyun();
                }
                else
                {
                    Console.WriteLine("Oyun Bitmiştir.yine bekleriz...");
                    break;
                }


            }


            Console.ReadLine();
        }
    }
}
