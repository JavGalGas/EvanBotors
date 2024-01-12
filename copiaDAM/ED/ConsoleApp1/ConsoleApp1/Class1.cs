using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public static int  SumatorioRec(int n)
        {
            if (n <= 0)
                return 0;
            return n + SumatorioRec(n - 1);
        }
    }
}
