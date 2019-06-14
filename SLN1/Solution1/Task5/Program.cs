using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number->");

            int Number = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------");

            Console.WriteLine("Absolute value of the number is " + Math.Abs(Number));

            Console.WriteLine("------------------");

            Console.WriteLine("Square root of the number is " + Math.Sqrt(Number));

            Console.WriteLine("------------------");

            Console.WriteLine("Sum is " + (Math.Pow(Number,3) + Math.Pow(Number/2,3)));

            Console.ReadKey();

            

        }
    }
}
