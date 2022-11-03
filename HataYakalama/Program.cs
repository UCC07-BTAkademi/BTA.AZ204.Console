using System;

namespace HataYakalama
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Örnek1
            int a = 100, b = 0;

            //Console.WriteLine("\n< C# Exception Handling (Hata Yakalama) >\n\n {0} / {1} işleminin sonucu: {2}\n{3}", a, b, (a / b));


            try
            {
                Console.WriteLine("\n< C# Exception Handling (Hata Yakalama) >\n\n-> {0} / {1} işleminin sonucu: {2}\n{3}", a, b, (a / b));
            }
            catch
            {
                if (a != 0 && b == 0)
                {
                    b = (a / 10);
                    Console.WriteLine("\n\n-> B'nin değeri hata oluşturduğu için güncellenmiş ve {0} değeri atanmıştır.\n-> {1} / {2} işleminin sonucu: {3}\n", b, a, b, (a / b));
                }
                else if (a == 0 && b != 0)
                {
                    a = (b * 10);
                    Console.WriteLine("\n\n-> A'nin değeri hata oluşturduğu için güncellenmiş ve {0} değeri atanmıştır.\n-> {1} / {2} işleminin sonucu: {3}\n", a, a, b, (a / b));
                }
                else if (a == 0 && b == 0)
                {
                    a = 50;
                    b = 10;
                    Console.WriteLine("\n\n-> {0} / {1} işleminin sonucu: {2}\n", a, b, (a / b));
                }
            }

            #endregion



            #region Örnek2

            int bolunen,bolen;

            try
            {
                Console.Write("\n-> Bölünecek Değeri Giriniz : ");
                bolunen = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n-> Bölen Değeri Giriniz: ");
                bolen = Convert.ToInt32(Console.ReadLine());

                double sonuc = bolunen / bolen;

                Console.WriteLine("\n-> {0} değerinin {1} değerine bölümünün sonucu: {2:0.00}\n", bolunen, bolen, sonuc);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\n-> Hata! Sıfıra bölüm işlemi gerçekleştirilemez.\n-> Hata Mesajı: {0}\n", e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("\n-> Hata! Sadece Int32 türünde veri girişi yapabilirsiniz.\n-> Hata Mesajı: {0}\n", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n-> Beklenmedik Bir Hata!\n-> Hata Mesajı: {0}\n", e.Message);
            }
            finally
            {
                Console.WriteLine("-> Finally Bloğu Çalışıyor.\n");
            }
            #endregion

            Console.ReadKey();

        }

    }
}

