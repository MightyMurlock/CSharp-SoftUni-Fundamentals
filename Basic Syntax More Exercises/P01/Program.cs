using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int firstNumber = Math.Max(Math.Max(number1, number2), number3);
            int thirdNumber = Math.Min(Math.Min(number1, number2), number3);
            int secondNumber = (number1 + number2 + number3) - (firstNumber + thirdNumber);

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
    }
}
