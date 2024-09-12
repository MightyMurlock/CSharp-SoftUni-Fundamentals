using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());

            //int sum = 0;
            //while (number != 0)
            //{

            //    int factorial = 1;
            //    int num = number % 10;
            //    number /= 10;

            //    for (int i = 2; i <= num; i++)
            //    {
            //        factorial *= i;
            //    }
            //    sum += factorial;
            //}
            ////Console.WriteLine(number);
            ////Console.WriteLine(sum);

            //if (sum == number)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}


            var n = int.Parse(Console.ReadLine());
            var nCopy = n;
            int sum = 0;

            while (n > 0)
            {
                var factoriel = 1;
                var number = n % 10;
                n /= 10;

                for (int i = 2; i <= number; i++)
                {
                    factoriel *= i;
                }

                sum += factoriel;
            }
            if (sum == nCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
