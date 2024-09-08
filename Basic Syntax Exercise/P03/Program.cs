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
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine(); 
            string day = Console.ReadLine();

            double price = 0;
            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        price = 8.45;
                    }
                    else if (type == "Business")
                    {
                        price = 10.90;
                    }
                    else if (type == "Regular")
                    {
                        price = 15;
                    }
                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        price = 9.80;
                    }
                    else if (type == "Business")
                    {
                        price = 15.60;
                    }
                    else if (type == "Regular")
                    {
                        price = 20;
                    }
                    break;
                case "Sunday":
                    if (type == "Students")
                    {
                        price = 10.46;
                    }
                    else if (type == "Business")
                    {
                        price = 16;
                    }
                    else if (type == "Regular")
                    {
                        price = 22.50;
                    }
                    break;
            }

            if (type == "Students" && peopleCount >= 30)
            {
                price -= (price * 0.15);
            }
            if (type == "Business" && peopleCount >= 100)
            {
                peopleCount -= 10;
            }
            if (type == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                price -= (price * 0.05);
            }

            price *= peopleCount;

            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}
