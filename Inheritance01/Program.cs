using System;

// Inheritance (miras alma, kalıtım), bir nesnenin özelliklerinin farklı nesneler tarafından da kullanılabilmesine olanak sağlayan OOP özelliğidir. Yazılan bir sınıf bir başka sınıf tarafından miras alınabilir. Bu işlem yapıldığı zaman temel alınan sınıfın tüm özellikleri yeni sınıfa aktarılır.

namespace Inheritance01
{
    class Program
    {
        static void Main(string[] args)
        {
            A asinifi = new A();

            int i=asinifi.a;

            Console.WriteLine("Hello World!");
        }
    }

    public class A : B
    {

    }

    public class B
    {
        public int a = 5;

        public void Deneme()
        {


        }
    }
}
