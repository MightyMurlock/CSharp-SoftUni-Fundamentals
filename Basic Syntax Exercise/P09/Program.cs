using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            double totalLightSabers, totalRobes, totalBelts = 0;
            double moneyNeeded;


            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double priceLightSabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            totalLightSabers = priceLightSabers * Math.Ceiling(studentCount + studentCount * 0.1);
            totalRobes = priceRobes * studentCount;
            if (studentCount >= 6)
            {
                totalBelts = priceBelts * (studentCount - Math.Floor((double)studentCount / 6));
            }
            else
            {
                totalBelts = priceBelts * studentCount;
            }

            totalPrice = totalLightSabers + totalRobes + totalBelts;

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                moneyNeeded = totalPrice - money;
                Console.WriteLine($"John will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
