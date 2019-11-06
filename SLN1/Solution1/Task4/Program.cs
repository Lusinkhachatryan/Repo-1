using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First number->");

            int Num1 = int.Parse(Console.ReadLine());

            Console.Write("Second number->");

            int Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------");

            double NumSqrt = Math.Sqrt(Num1);

            Console.WriteLine("Square root of the First number is " + NumSqrt);

            Console.WriteLine("------------------");

            int NumDiff = Math.Abs(Num1 - Num2);

            Console.WriteLine("Absolute value of the subtraction is " + NumDiff);

            Console.WriteLine("------------------");

            double NumPow = Math.Pow(Math.Max(Num1, Num2), 3);

            Console.WriteLine("The max number raised to 3 power is " + NumPow);

            Console.WriteLine("------------------");

            bool IsEqual = Num1++ == --Num2;

            Console.WriteLine("Postfix increment of the first number is equal to prefix decrement of the second one -> " + IsEqual);

            Console.ReadKey();




        }
    }
}
