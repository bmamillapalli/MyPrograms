using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class Class
    {
        int alpha, beta;

        public Class(int a,int b)
        {
            this.alpha = a;
            this.beta = b;
        }

        public bool Input(Class obj)
        {
            if ((obj.alpha == alpha) && (obj.beta == beta))
            {
                return true;
            }
            else
                return false;
        }
    }

    class ClassDemo
    {
        static void Main(string[] args)
        {
            Class ob = new Class(5, 10);
            Class ob2 = new Class(1, 2);
        }
    }
}
