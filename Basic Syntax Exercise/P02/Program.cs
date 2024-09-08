using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int option = 0;

            if (number % 2 == 0)
            {
                option = 2;
            }
            if (number % 3 == 0)
            {
                option = 3;
            }
            if (number % 6 == 0)
            {
                option = 6;
            }
            if (number % 7 == 0)
            {
                option = 7;
            }
            if (number % 10 == 0)
            {
                option = 10;
            }

            switch (option)
            {
                case 2:
                    Console.WriteLine($"The number is divisible by 2");
                    break;
                case 3:
                    Console.WriteLine($"The number is divisible by 3");
                    break;
                case 6:
                    Console.WriteLine($"The number is divisible by 6");
                    break;
                case 7:
                    Console.WriteLine($"The number is divisible by 7");
                    break;
                case 10:
                    Console.WriteLine($"The number is divisible by 10");
                    break;
                default:
                    Console.WriteLine("Not divisible");
                    break;
            }
        }
    }
}
