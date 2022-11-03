using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstraction
{
    public class Araclar
    {

        public interface IArac
        {
            // Sadece bir aracın en ortak ozelliklerini topladığımız bir Interface

            void Git();

            void Dur();

            //void PencereyiAc(); // Buraya koymamız gereksiz. Çünkü Penceresi olmayan bir aracımız olabilir (bisiklet,uçak gibi)

        }

        public interface IBinilebilir
        {
            void Bin();
        }

        public interface IUcabilir
        {
            void IniseGec();
        }

        //
        public abstract class BaseArac : IArac
        {
            public void Dur()
            {
                Console.WriteLine("Araç durdu....");
            }

            public void Git()
            {
                Console.WriteLine("Araç gidiyor....");
            }
        }



        public class Araba : BaseArac
        {
            // aşağıdakiler her araçta ortak ....dolayısı ile bir base class oluşturabiliriz ve bunları oraya taşıyabiliriz

        }

        public class Bisiklet : BaseArac, IBinilebilir
        {
            public void Bin()
            {
                throw new NotImplementedException();
            }


        }

        //
        public class Ucak : BaseArac, IUcabilir
        {


            public void IniseGec()
            {
                throw new NotImplementedException();
            }
        }
    }
}
