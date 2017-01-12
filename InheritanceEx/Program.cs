using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    public interface CAl
    {
        void Add();
        void Sub();
        void Mul();
        void Div();
    }
    class Employment
    {
        public static string name;
        public int salary;

        public Employment(string name, int salary)
        {
            Employment.name = name;
            this.salary = salary;
        }

        public static void Print()
        {
            Console.WriteLine("PArent");
        }

        public virtual void AllDetails()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Salary:" + salary);
        }
    }
    class PartTime : Employment, CAl
    {
        public PartTime(string name, int salary) : base(name, salary)
        {

        }
        

        string type = "PartTime";
        public override void AllDetails()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Salary:" + salary);
            Console.WriteLine("Emplyment Type:" + type);
        }

        public void Add()
        {

        }
        public void Sub()
        {
        }

        public void Mul()
        {

        }
        public void Div()
        {

        }
        class FullTime : Employment
        {
            public FullTime(string name, int salary) : base(name, salary)
            {

            }
            string type = "FullTime";

            public new static void Print()
            {
                Console.WriteLine("Full");
            }

            public override void AllDetails()
            {
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Salary:" + salary);
                Console.WriteLine("Emplyment Type:" + type);


                


            }
            public void Benifits()
            {
                IList<string> hobby = new List<string>();
                ICollection<string> able = new HashSet<string>();
                ICollection<string> aaa = new List<string>();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {

                //Employment obj = new PartTime("Brahmi", 5000);

                //obj = new FullTime("s:",5);

                Employment fobj = new FullTime("Kowsik", 10000);

                //CAl objc = new PartTime("shu", 500);
                Console.WriteLine("*******");
                fobj.AllDetails();
                
                //obj.AllDetails();


                Console.Read();
            }
        }
    }
}
