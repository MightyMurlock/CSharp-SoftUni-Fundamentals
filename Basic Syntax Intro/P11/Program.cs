using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int mult = int.Parse(Console.ReadLine());
            int res = 0;

            if (mult > 0 && mult <= 10)
            {
                for (int i = mult; i <= 10; i++)
                {
                    res = num * i;
                    Console.WriteLine($"{num} X {i} = {res}");
                }
            }
            else
            {
                res = num * mult;
                Console.WriteLine($"{num} X {mult} = {res}");
            }
        }
    }
}
