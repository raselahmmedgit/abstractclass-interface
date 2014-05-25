using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInterface
{
    class Savings : Account
    {
        public override void Deposit()
        {
            throw new NotImplementedException();
        }
    }
}
