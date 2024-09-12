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
            string input = string.Empty;
            double coins = 0;
            double money = 0;
            while (input != "Start")
            {
                input = Console.ReadLine();
                bool x = double.TryParse(input, out coins);
                if (x == false)
                {
                    continue;
                }
                switch (coins)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        money += coins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
            }
            
            input = string.Empty;
            while (input != "End")
            {
                input = Console.ReadLine();
                
                switch (input)
                {
                    case "Nuts":
                        if (money >= 2)
                        {
                            Console.WriteLine("Purchased nuts");
                            money -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (money >= 0.7)
                        {
                            Console.WriteLine("Purchased water");
                            money -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (money >= 1.5)
                        {
                            Console.WriteLine("Purchased crisps");
                            money -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (money >= 0.8)
                        {
                            Console.WriteLine("Purchased soda");
                            money -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (money >= 1)
                        {
                            Console.WriteLine("Purchased coke");
                            money -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "End":
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
