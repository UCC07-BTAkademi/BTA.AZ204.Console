using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Abstract tarafı ortak olan metotları bir base classa taşımamıza olanak verir
// abstract classdan bir instance yapılamaz
// ortak noktaların tesbiti
// abstract içine kod yazabiliyoruz

//============================
// bir BaseMarka isimli class yaratıp içine yakıtmaliyeti metodunu koyalım ve diğer sınıfları ondan inherit edelim.


namespace InterfacesAbstraction
{
    public abstract class BaseMarka // Diğer classlara hizmet eden bir class..Dolayısı ile bu classı sadece bunlar kullansın istiyorum. Bundan bir instance yaratılabilsin istemeyebilirim. bu durumda bunu soyutlamak için abstract keywordu kullanarak soyutluyorum.
    {
        public void YakitMaliyetiHesapla()
        {
            // Yakıt maliyeti hesabı yapan metot
        }

        public abstract int GetYear();

    }


    public class Mercedes:BaseMarka
    {
        public string GetModel() 
        {
            return "CLS200";
        }

        public override int GetYear()
        {
            return 2010;
        }

        //public void YakitMaliyetiHesapla()
        //{
        //    // Yakıt maliyeti hesabı yapan metot
        //}

    }

    public class Volvo:BaseMarka
    {
        public string GetModel()
        {
            return "XC70";
        }

        public override int GetYear()
        {
            return 2005;
        }

        //public void YakitMaliyetiHesapla()
        //{
        //    // Yakıt maliyeti hesabı yapan metot
        //}
    }

    // yeni bir class yaratalım ama mesela get year metodunu abstract classın içine kopyalayalım ve içini silelim. Yani interface gibi davranalım. diğer her sınıfta o metodu override edelim
    public class VW : BaseMarka
    {
        public string GetModel()
        {
            return "Scirocco";
        }

        public override int GetYear()
        {
            return 2005;
        }
    }
}
