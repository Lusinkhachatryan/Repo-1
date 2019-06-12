using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a three digit number->");
            int Number = int.Parse(Console.ReadLine());
            

            int Digit1 = Number % 10;
            Number /= 10;
            int Digit2 = Number % 10;
            int Digit3 = Number / 10;
            float Average = (Digit1 + Digit2 + Digit3) / 3f;
            Console.WriteLine("Arithmetic average is " + Average);
            Console.ReadKey();
        
        }
    }
}
