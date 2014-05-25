using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInterface
{
    class Employee : IPrint
    {
        public string Name { set; get; }
        public void SetPortNo(int no)
        {
            throw new NotImplementedException();
        }

        public int GetPortNo()
        {
            throw new NotImplementedException();
        }

        public void Print(string something)
        {
            Console.WriteLine(Name);
        }
    }
}
