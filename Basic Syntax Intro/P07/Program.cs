using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ticket = 0;

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            switch (day)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        ticket = 12;
                        Console.WriteLine(ticket + "$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticket = 18;
                        Console.WriteLine(ticket + "$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticket = 12;
                        Console.WriteLine(ticket + "$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        ticket = 15;
                        Console.WriteLine(ticket + "$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticket = 20;
                        Console.WriteLine(ticket + "$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticket = 15;
                        Console.WriteLine(ticket + "$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        ticket = 5;
                        Console.WriteLine(ticket + "$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticket = 12;
                        Console.WriteLine(ticket + "$");
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticket = 10;
                        Console.WriteLine(ticket + "$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
