using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInterface
{
    interface IPrint
    {
        void SetPortNo(int no);
        int GetPortNo();
        void Print(string something);
    }
}
