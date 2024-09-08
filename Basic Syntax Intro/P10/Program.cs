using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int res = 0;

            for (int i = 1; i <= 10; i++)
            {
                res = num * i;
                Console.WriteLine($"{num} X {i} = {res}");
            }
        }
    }
}
