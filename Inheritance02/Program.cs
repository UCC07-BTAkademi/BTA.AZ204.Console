using System;

// base class, derived class (kalıtım veren : base/parent) (kalıtım alan : child..türetilen)

// bir sınıfın sadece ve sadece tek bir base classı olabilir

namespace Inheritance02
{
    class Program
    {
        static void Main(string[] args)
        {

            new Kizim();

            new MyClass2();

            new MyClass2(5);

            Console.ReadKey();
        }
    }

    class Buyukbaba
    {

    }

    class Baba : Buyukbaba
    {

    }

    class Ben: Baba
    {

    }

    class Kizim : Ben
    {

    }

    class Amcam : Buyukbaba // derived class aynı zamanda bir base class olabilir
    {

    }

    class Kuzen1 : Amcam
    {

    }

    class Kuzen2 : Amcam
    {

    }

    #region Nesne üretim sırası

    // kalıtım aldığı sınıflar varsa önce onlardan nesne üretilir A..B..C

    #endregion


    #region base keyword kullanımı
    // 1.base classın constructorlarına ulasabilmeyi sağlar
    // 2.
    class MyClass
    {
        // ctor 
        public MyClass(int a)
        {
            Console.WriteLine("MyClass yaratılırkenki parametre değeri {0}",a);
        }
    }

    class MyClass2 : MyClass
    {
        public MyClass2() : base(10)
        {

        }

        public MyClass2(int a) : base (a)
        {

        }
    }

    #endregion
}
