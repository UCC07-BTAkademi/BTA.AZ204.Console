using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public class Employee : IPerson
    {
        public string FName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    }


}
