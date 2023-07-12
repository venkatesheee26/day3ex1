using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Please provide a username and password.");
            }
            else if (username == "admin1256" && password == "admin@1256@1256")
            {
                Console.WriteLine("Sign-in successful!");
            }
            else
            {
                Console.WriteLine("Invalid user.");
            }

            Console.ReadLine();

        }
    }
}
