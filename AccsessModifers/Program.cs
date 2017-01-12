using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccsessModifers
{
    class Program
    {
        private string ssn;
        string fname, lname, phNo;

        public void CustDetails()
        {
            Console.WriteLine("Enter Customer First Name: {0}", fname);
            fname = Console.ReadLine();
            Console.WriteLine("Enter Customer Last Name: {0}", lname);
            lname = Console.ReadLine();
            Console.WriteLine("Enter Customer Social Security Number: {0}", ssn);
            ssn = Console.ReadLine();
            Console.WriteLine("Enter Customer Phone Number: {0}", phNo);
            phNo = Console.ReadLine();

        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.CustDetails();
        }
    }
}
