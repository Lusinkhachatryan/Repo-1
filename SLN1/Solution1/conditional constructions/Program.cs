using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_constructions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.Write("Enter 2 numbers->");
            int Number1 = int.Parse(Console.ReadLine());
            int Number2 = int.Parse(Console.ReadLine());
            double Numb1Squere = Math.Pow(Number1, 2);
            double Numb2Squere = Math.Pow(Number2, 2);

            //Version 1- if-esle
            if (Numb1Squere > Numb2Squere)

            {

                Console.WriteLine(Numb1Squere + ">" + Numb2Squere);

            }

            else if (Numb1Squere < Numb2Squere)

            {

                Console.WriteLine(Numb1Squere + "<" + Numb2Squere);

            }

            else

            {

                Console.WriteLine(Numb1Squere + "=" + Numb2Squere);

            }

            Console.ReadKey();

            //Version 2 - switch-case

            int Comperison = (Numb1Squere > Numb2Squere ? 1 : Numb1Squere < Numb2Squere ? 2 : 3);

            switch (Comperison)
            {
                case 1:
                    Console.WriteLine(Numb1Squere + ">" + Numb2Squere);
                    break;

                case 2:
                    Console.WriteLine(Numb1Squere + "<" + Numb2Squere);
                    break;

                case 3:
                    Console.WriteLine(Numb1Squere + "=" + Numb2Squere);
                    break;

            }
            Console.ReadKey();

            //Task 2
            Console.Write("Enter 4 numbers->");
            int Number01 = int.Parse(Console.ReadLine());
            int Number02 = int.Parse(Console.ReadLine());
            int Number03 = int.Parse(Console.ReadLine());
            int Number04 = int.Parse(Console.ReadLine());

            double Num01PowNum02 = Math.Pow(Number01, Number02);
            double Num03PowNum04 = Math.Pow(Number03, Number04);
            bool Comperison2 = Num01PowNum02 == Num03PowNum04;

            switch (Comperison2)
            {
                case true:
                    Console.WriteLine(Num01PowNum02 + "=" + Num03PowNum04);
                    break;

                case false:
                    Console.WriteLine(Num01PowNum02 + "!=" + Num03PowNum04);
                    break;

            }
            Console.ReadKey();

            // The largest objects that orbit the Sun
            Console.WriteLine("Enter a number from 1 to 8 to know the planets from smallest to largest");
            int Order = int.Parse(Console.ReadLine());

            if (Order > 8)

            {

                Console.WriteLine("Youn need to enter a number from 1 to 8");

            }

            switch (Order)
            {
                case 1:
                    Console.WriteLine("Mercury - (diameter = 4879.4 km)");
                    break;

                case 2:
                    Console.WriteLine("Mars - (diameter = 6787 km)");
                    break;
                case 3:
                    Console.WriteLine("Venus - (diameter = 12,104 km)");
                    break;
                case 4:
                    Console.WriteLine("Earth - (diameter = 12,756 km)");
                    break;
                case 5:
                    Console.WriteLine("Neptune - (diameter -= 49,528 km)");
                    break;
                case 6:
                    Console.WriteLine("Uranus - (diameter = 51,118 km)");
                    break;
                case 7:
                    Console.WriteLine("Saturn - (diameter = 120,660 km)");
                    break;
                case 8:
                    Console.WriteLine("Jupiter - (diameter = 142,800 km)");
                    break;

            }
            Console.ReadKey();



        }
    }
}
