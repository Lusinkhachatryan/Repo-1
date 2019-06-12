using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter five negative numbers separated by a comma(,) ->");
            var Nums = Console.ReadLine();
            var NumberList = Nums.Split(',');
            int Num1 = int.Parse(NumberList[0]);
            int Num2 = int.Parse(NumberList[1]);
            int Num3 = int.Parse(NumberList[2]);
            int Num4 = int.Parse(NumberList[3]);
            int Num5 = int.Parse(NumberList[4]);
            Console.WriteLine("The Result is -> "+ Math.Abs(Num1 * Num2 * Num3 * Num4 * Num5));
            Console.ReadKey();

        }
    }
}
