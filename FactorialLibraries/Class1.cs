using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialLibraries
{
    public class Factorial
    {
        public int Fact(int x)
        {
            int result = 1;
            if (x == 0)
                return 1;
            for (int i = 1; i <= x; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
