using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] usernameChar = username.ToCharArray();
            Array.Reverse(usernameChar);
            string password = new string(usernameChar);

            string passwordInput = Console.ReadLine();

            int attempts = 0;
            while (passwordInput != password && attempts != 3)
            {
                Console.WriteLine("Incorrect password. Try again.");
                attempts++;
                passwordInput = Console.ReadLine();
            }

            if (attempts == 3)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
