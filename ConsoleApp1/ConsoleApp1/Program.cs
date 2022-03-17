using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("username");
            string username = Convert.ToString(Console.ReadLine());
            Console.WriteLine("password");
            string password = Convert.ToString(Console.ReadLine());
            Admin admin = new Admin(username, password);
            

        }
    }
}
