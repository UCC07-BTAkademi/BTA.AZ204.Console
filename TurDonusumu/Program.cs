using System;

namespace TurDonusumu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bilinçsiz - implicit tür dönüşümleri

            //byte a = 10;
            //short b = 5;
            //sbyte c = 30;

            //int d = a + b + c;

            ////---------
            //string e = "Deneme ";
            //char f = '1';
            //object g = e + f + d;

            //long h = d;

            //float i = h;

            //double j = i;

            //double k = 25.8f;

            //Console.WriteLine(j + k);

            //Console.ReadKey();


            // Bilinçli - explicit tür dönüşümleri

            // Bilinçli tür dönüşümü genellikle derleyicinin izin vermediği durumlarda kullanılır.

            //int a = 5;
            //byte b = (byte)a;
            //Console.WriteLine(b);

            //int c = 100; // Sizce ne olur?
            //byte i = (byte)c;
            //Console.WriteLine(i);

            //int d = 500; // Sizce ne olur?
            //byte j = (byte)d;
            //Console.WriteLine(j);


            // object türü
            //object türündeki bir değişkene başka herhangi bir türdeki değişken ya da sabit (string dışında) + işaretiyle eklenemez.

            //object o = '5';
            //int z = 4;
            //Console.WriteLine(o + z);

            //object türündeki bir değişkene herhangi bir türdeki değişken ya da sabit atanabilir (bilinçsiz tür dönüşümü). Ancak object türündeki herhangi bir değişkeni başka bir türe çevirmek için tür dönüştürme işlemi kullanılır. Ayrıca da dönüştürülen türlerin uyumlu olması gerekir. Yani object türüne nasıl değer atandığı önemlidir. Örneğin aşağıdaki gibi bir durum hatalıdır:

            object a = "5";
            int b = (int)a;
            Console.WriteLine(b);

            //Ancak aşağıdaki gibi bir kullanım doğrudur.
            object a1 = 'k';
            char b1 = (char)a1;
            Console.WriteLine(b);

            // string ile ilgili dönüşümler
            string b2 = 3.ToString();
            Console.WriteLine(b2);





            Console.ReadKey();
        }
    }
}
