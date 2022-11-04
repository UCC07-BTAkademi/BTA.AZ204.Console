using System;

// Kullanıcı klavyeden 20 adet yaş bilgisi girecek. Girilen bu bilgilerin içinden 19-26 yaş aralığındakilerin adetlerini sayan programcık

namespace WO_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet = 0;
            int yas = 0;
            int i = 0;
            // for çevrimi ile

            //for (int i = 0; i <10; i++)
            //{
            //    Console.Write("{0}. yaşı giriniz",i+1);

            //    yas = Convert.ToInt32(Console.ReadLine());

            //    if (yas >= 19 && yas <=26)
            //    {
            //        adet++;
            //    }


            //}
            //Console.WriteLine("19 ile 26 yaş arası {0} kişi vardır...",adet);

            // while döngüsü ile
            while (i<10)
            {
                Console.Write("{0}. yaşı giriniz", i + 1);

                yas = Convert.ToInt32(Console.ReadLine());

                if (yas >= 19 && yas <= 26)
                {
                    adet++;
                }

                i++;
            }

            Console.WriteLine("19 ile 26 yaş arası {0} kişi vardır...",adet);

            Console.ReadKey();
        }
    }
}
