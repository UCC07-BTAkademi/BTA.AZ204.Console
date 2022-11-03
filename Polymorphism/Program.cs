using System;

// Polymorphism, çok biçimlilik olarak tanımlayabileceğimiz bir kavramdır.
// programımızda oluşan bir nesne yapısının birbirinden farklı nesneler şeklinde davranmasını sağlayan yapıdır.
// Farklı işlemler yapan fakat aynı isimdeki özellik veya metotların kullanımına çok biçimlilik (polymorphism) denmektedir. 
// Daha belirgin olarak, metotları ve türetilmiş sınıfları yeniden tanımlama yeteneğidir.



namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan();
            Hayvan kedi = new Kedi();
            Hayvan kopek = new Kopek();

            hayvan.SesVer();
            kedi.SesVer();
            kopek.SesVer();

            Console.ReadKey();

        }
    }

    class Hayvan
    {
        public void SesVer()
        {
            Console.WriteLine("Hayvan sesleniyor...");
        }
    }

    class Kedi : Hayvan
    {
        public void SesVer()
        {
            Console.WriteLine("Kedi dedi ki : miyav miyav...");
        }
    }

    class Kopek : Hayvan
    {
        public void SesVer()
        {
            Console.WriteLine("Köpek dedi ki : hav hav....");
        }
    }
}
