using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringRecursive
{
    class Program
    {
        public  void ReverseString(string s)
        {
            if (s.Length <= 0)
                return;
            else
                ReverseString(s.Substring(1, s.Length - 1));
                Console.Write(s[0]);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ReverseString("brahmi");
            Console.Read();
        }
    }
}
