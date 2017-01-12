using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOperations
{
    class xyz
    {
        int x = 0, y = 0;
        public xyz()
        {

        }
        public xyz(int a,int b)
        {
            a = x;
            b = y;
        }
        public static xyz operator +(xyz i,xyz j)
        {
            xyz result = new xyz();
            result.x = i.x + j.x;
            result.y = i.y + j.y;
            return result;
        }
    }
    class StaticClass
    {
        static void Main(string[] args)
        {

            /*xyz a = new xyz(2,5);
            xyz b = new xyz();
            xyz c;

            c = a + b;
             
            Console.WriteLine("A value: " + a);
            StaticClass.a = 50;
            Console.WriteLine("A value: " + a);

            Console.Read();*/
        }
    }
}
