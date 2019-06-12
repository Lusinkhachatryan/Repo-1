using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposit___calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deposit Amount -> ");
            int Amount = int.Parse(Console.ReadLine());
            Console.Write("Interest rate ->");
            double IntRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Total Amount will be " + Amount*(1+IntRate/100*3));
            Console.ReadKey();

        }
    }
}
