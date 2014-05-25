using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInterface
{
    abstract class Account : IPrint
    {
        private string No { set; get; }

        public abstract void Deposit();

        public void Withdraw()
        {
            //TODO
        }

        public virtual void Transfer()
        {

        }


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
            Console.WriteLine(No);
        }
    }
}
