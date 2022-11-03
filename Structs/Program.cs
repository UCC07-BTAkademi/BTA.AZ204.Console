using System;

// class yapısına göre daha basit düzeyde işlemler gerçekleştirmemizi sağlayan ve belirli bir takım kısıtlamaları yanında barındıran bir yapıdır. class kadar kompleks işlemler için tasarlanmış bir yapı gerektirmiyorsa tercih edilebilir.struct yapıları bir Değer Tipli(Value Types) değişken özelliği göstermektedir.Yani  “int” gibi, “bool” gibi değer tipli bir değişken oluşturmak istiyorsanız struct yapısını tercih edebilirsiniz.

// Tıpkı sınıflar gibi yapılarda da new operatörüyle nesne yaratılabilir. new anahtar sözcüğünü kullandığımızda yapının varsayılan yapıcı metodu veya varsa kendi tanımladığımız yapıcı metot çalıştırılır.
// Sınıflardan farklı olarak YapiAdi nesne; yazarak bir yapı nesnesini oluşturup kullanılabilir hâle getirebiliriz. İllaki new anahtar sözcüğünü kullanmak zorunda değiliz.

// Yapı nesneleriyle ilgili işlemler, sınıf nesneleriyle ilgili işlemlerden daha hızlı gerçekleşir.

// Tıpkı sınıflardaki gibi normal metotlar da bir yapı içerisinde bildirilebilir.

namespace Structs
{
    class Program
    {
        struct Personel
        {
            public int Id;
            public string Ad;

            public void getId(int id)
            {
                Console.WriteLine("Personel Id: " + id);
            }

            // constructor da kullanabiliyoruz...Parametreli olarak

            public Personel(int personelId, string personelAd)
            {

                Id = personelId;
                Ad = personelAd;
            }
        }
        
        static void Main(string[] args)
        {



            //Personel personel; //1.durum
            Personel personel = new Personel(1, "ÜmitK"); // 2.durum

            // accesses and sets struct field
            //personel.Id = 1;

            // accesses struct methods
            //personel.getId(personel.Id);


            Console.WriteLine("Personel Adı : " + personel.Ad);
            Console.WriteLine("Personel No : " + personel.Id);

            Console.ReadKey();
        }
    }
}
