using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsernamePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            string user, pass;


            do
            {
                Console.WriteLine("Login Attempt " + (x + 1));
                Console.Write("Enter The Username:");
                user = Console.ReadLine();
                Console.Write("Enter The Password:");
                pass = Console.ReadLine();
                Console.WriteLine();

                x++;
            } while ((user != "username" && pass != "password") && (x != 3));


            if (user == "username" && pass == "password")
                Console.WriteLine("Login Successful!!");
            else
                Console.WriteLine("Login Failed!!");

            Console.Read();
        }
    }
}
