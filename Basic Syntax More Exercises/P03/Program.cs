using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double totalSpent = 0;
            bool done = false;

            double balance = double.Parse(Console.ReadLine());

            while /*(input != "Game Time" || balance != 0)*/(done || balance != 0)
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "OutFall 4":
                        if (balance >= 39.99)
                        {
                            balance -= 39.99;
                            totalSpent += 39.99;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (balance >= 15.99)
                        {
                            balance -= 15.99;
                            totalSpent += 15.99;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance >= 19.99)
                        {
                            balance -= 19.99;
                            totalSpent += 19.99;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (balance >= 59.99)
                        {
                            balance -= 59.99;
                            totalSpent += 59.99;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (balance >= 29.99)
                        {
                            balance -= 29.99;
                            totalSpent += 29.99;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99)
                        {
                            balance -= 39.99;
                            totalSpent += 39.99;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Game Time":
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (input == "Game Time")
                {
                    break;
                }
            }

            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
