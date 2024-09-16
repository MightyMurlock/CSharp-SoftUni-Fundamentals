using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputChar = input.ToCharArray();
            Array.Reverse(inputChar);
            string output = new string(inputChar);

            Console.WriteLine(output);
        }
    }
}
