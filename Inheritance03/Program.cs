using System;



namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpManager emp = new EmpManager();

            emp.createEmployee("Ahmet", "Mehmet", "Beden İşçisi");
            emp.infoEmployee();

            EngManager eng = new EngManager();
            
            eng.createEmployee("Ali", "Veli", "Mühendis");
            eng.infoEmployee();
            eng.addMoney(12.5);


            Console.ReadKey();
        }
    }

    // Üst Sınıf
    class EmpManager
    {
        protected string empName, empSurname, empJob; // protected: Tanımlandığı sınıfta ve o sınıfı miras (kalıtım) alan sınıflardan erişmek mümkündür
        protected int empSalary = 3000;
        private string moneyType = "TL";

        public string moneyT
        {
            get { return moneyType; }
            set { moneyType = value; }
        }
        
        public void createEmployee(string empName, string empSurname, string empJob)
        {
            this.empName = empName;
            this.empSurname = empSurname;
            this.empJob = empJob;

            if (empSalary == 0)
                this.empSalary = 3000;

            Console.WriteLine("\n-> Kullanıcı bilgileri sisteme eklendi. Eklenen bilgiler : \n");

        }

        public void deleteEmployee()
        {
            this.empName = null;
            this.empSurname = null;
            this.empJob = null;
            this.empSalary = 0;

            Console.WriteLine("\n-> Kullanıcı bilgileri sistemden kaldırıldı.\n");
        }

        public void infoEmployee()
        {
            if (empName != null && empSurname != null && empJob != null)
                Console.WriteLine("-> Çalışanın İsmi: {0}\n-> Çalışanın Soyadı: {1}\n-> Çalışanın Unvanı: {2}\n-> Çalışanın Maaşı: {3} {4}\n", empName, empSurname, empJob, empSalary, moneyType);
            else
                Console.WriteLine("-> Henüz kayıtlı bir kullanıcı bilgisi oluşturmadınız.\n");
        }
    }

    // Alt Sınıf
    class EngManager : EmpManager
    {
        private int firstSalary;

        public EngManager()
        {
            empSalary = empSalary + Convert.ToInt32(empSalary * 1.5);

            firstSalary = empSalary;
            
            moneyT = "USD";
        }

        public void addMoney(int v)
        {
            empSalary = empSalary + v;

            showInfo();
        }
        
        public void addMoney(double v)
        {
            empSalary = empSalary + Convert.ToInt32(empSalary * (v / 100));

            showInfo();
        }
        
        private void showInfo()
        {
            Console.WriteLine("-> Zam uygulaması başarılı bir şekilde gerçekleştirildi.\n-> Zam öncesi çalışnanın maaşı {0} {1} iken şu an {2} {3} artış ile {4} değerine ulaşmıştır.\n", firstSalary, moneyT, (empSalary - firstSalary), moneyT, empSalary);
        }
    }
}
