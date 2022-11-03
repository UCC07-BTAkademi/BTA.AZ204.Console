using System;


// Metot aşırı yükleme(overloading), bir Statik Polimorfizm örneğidir. Overloading(aşırı yüklenme), aynı isme sahip metot veya fonksiyonun farklı imzalar(parametreler) alacak şekilde tanımlanmasıdır. Compile Time(Derleme zamanı) Polymorphism olarak da bilinir, çünkü hangi metodun veya fonksiyonun çağrılacağına derleme zamanında karar verilir. C # derleyicisi, gönderilen parametrelerin sayısını ve parametre türünü kontrol eder ve hangi metodun veya fonksiyonun  çağrılacağına karar verir ve eşleşen bir metot veya fonksiyon  bulunmazsa hata verir. 

namespace StaticPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sampleclass  = new SampleClass();
            int UcSayiToplami = sampleclass.Toplama(45, 34, 67);
            Console.WriteLine($"Üç sayı toplamı : {UcSayiToplami}\n");
            int ikiSayiToplami = sampleclass.Toplama(23, 34);
            Console.WriteLine($"İki sayı toplamı : {ikiSayiToplami}\n");

            Console.ReadKey();
        }
    }

    class SampleClass
    {
        public int Toplama(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Toplama(int a, int b)
        {
            return a + b;
        }
    }
}
