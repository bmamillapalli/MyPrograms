using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimalLibraries
{
    public class BinaryToDecimal
    {
        public string B2D(int a)
        {
            string bin = "";
            int rem;

            while (a > 1)
            {
                rem = a % 2;
                bin = Convert.ToString(rem) + bin;
                a = a / 2;
            }
            bin = Convert.ToString(a) + bin;
            return bin;
        }
    }
}
