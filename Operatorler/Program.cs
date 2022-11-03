using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matematiksel Operatörler : + - * / %
            //int i = 5 % 2;

            //Console.Write("Değer : " + i);

            // iki operand farklı türlerdeyse sonuc daha üst kapasiteli olan tür türünden olacaktır

            //float j = 5 / 2f;

            //Console.Write("Değer : " + j);

            // Çoklu işlem

            float k = 2f / 5 / 6 / 3 / 8;



            Console.WriteLine("Değer : " + k);


            //Bir artırma ve bir eksiltme operatörleri
            //C#'ın en çok kullanılan operatörlerindendir. Önüne veya sonuna geldiği değişkeni bir artırır veya bir eksiltirler, sabitlere uygulanamazlar. Hem uygulandığı değişkenin değerini 1 artırır veya eksiltirler hem de tutucu vazifesi görürler. Ön ek ve son ek olmak üzere iki şekilde kullanılabilirler. 

            int a1 = 5;
            int i1 = ++a1;
            Console.WriteLine(i1 + " " + a1);

            //Programda da gördüğünüz gibi ++ operatörü hem a'nın değerini bir artırdı hem de bu değeri tuttu ve değer i'ye atandı. İşte ön ek ve son ek şeklinde kullanımın farkı burada ortaya çıkıyor. 

            int a2 = 5;
            int i2 = a2++;
            Console.WriteLine(i2 + " " + a2);
            // Bu programda ++ operatörü ön ek şeklinde değil de son ek şeklinde kullanılmış. Bu durumda 7. satırda önce a'nın değeri i'ye atanır, sonra a'nın değeri 1 artırılır. Halbuki ilk örneğimizde önce a'nın değeri 1 artırılmış sonra bu değer i'ye atanmıştı.

            // Bazı ++ --
            int a3 = 5;
            int i3 = a3++;
            int b3 = i3--;
            int c3 = 10;
            int d3 = --c3;
            Console.Write("{0}\n{1}\n{2}\n{3}", a3, i3, b3, d3);

            //Bu program ekrana alt alta 6, 4, 5 ve 9 yazacaktır. Dikkat ettiyseniz Write metodunu farklı şekilde kullandık. Siz de böyle çok fazla değişkeni daha kolay yazdırabilirsiniz. Ayrıca bu yöntemi WriteLine metodunda da kullanabilirsiniz.

            object i = "50";
            string s = i as string;
            Console.Write(s);

            Console.ReadKey();
        }
    }
}
