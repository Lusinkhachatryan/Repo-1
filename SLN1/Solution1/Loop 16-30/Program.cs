using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_16_30
{
    class Program
    {
        static void Main(string[] args)
        {
            ////task 16 
            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());
            //int Sum = 0;
            //int Qnt = 0;
            //int Prod = 1;
            //for (int i = 1; Number > 0; i++)
            //{
            //    int Digit = Number % 10;
            //    Number = Number / 10;
            //    Sum += Digit;
            //    Qnt = Qnt + 1;
            //    Prod = Prod * Digit;
            //}
            //Console.WriteLine(Sum);
            //Console.WriteLine(Qnt);
            //Console.WriteLine(Prod);
            //Console.ReadKey();

            ////task 17
            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());
            //string MinDig = "Not found";
            //int OddDig = 9;
            //for (int i = 1; Number > 0; i++)
            //{
            //    int Digit = Number % 10;
            //    Number = Number / 10;
            //    if (Digit % 2 != 0 && (Digit - OddDig) < 0)
            //    {
            //        OddDig = Digit;
            //        MinDig = " " + Digit;
            //    }

            //}

            //Console.WriteLine(MinDig);
            //Console.ReadKey();

            ////task 18
            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());
            //string SumDig = "Not found";
            //int OddDig = 0;
            //for (int i = 1; Number > 0; i++)
            //{
            //    int Digit = Number % 10;
            //    Number = Number / 10;
            //    if (Digit % 2 != 0 && Digit > 4)
            //    {
            //        OddDig = OddDig + Digit;
            //        SumDig = " " + OddDig;
            //    }

            //}

            //Console.WriteLine(SumDig);
            //Console.ReadKey();

            ////task 19
            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());
            //string SumDig = "Not found";
            //int OddDig = 1;
            //for (int i = 1; Number > 0; i++)
            //{
            //    int Digit = Number % 10;
            //    Number = Number / 10;
            //    if (Digit % 2 == 0 && Digit < 7)
            //    {
            //        OddDig = OddDig * Digit;
            //        SumDig = " " + OddDig;
            //    }

            //}

            //Console.WriteLine(SumDig);
            //Console.ReadKey();

            //// task 20

            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());
            //MaxMinDig(Number);

            //// task 21

            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());
            //Divisors(Number);

            //// task 22

            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());
            //DivisorsSum(Number);

            //// task 23

            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());
            //DivisorsSumQnt(Number);

            //// task 24

            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());

            //PowOfThree(Number);
            //Console.ReadKey();

            //// task 25

            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());

            //PowOfTwo(Number);
            //Console.ReadKey();

            //// task 28

            //Console.Write("Enter a natural number->");
            //int Number = int.Parse(Console.ReadLine());

            //SumOfDig(Number);
            //Console.ReadKey();

            // task 29 = task 15

            // task 30
                        
            FourDigNumbCheck();
            Console.ReadKey();

        }
        static void MaxMinDig(int N)
        {
            int DigMin = 9;
            int DigMax = 0;
            for (int i = 1; N > 0; i++)
            {
                int Digit = N % 10;
                N = N / 10;

                if (Digit > DigMax)
                    DigMax = Digit;
                if (Digit < DigMin)
                    DigMin = Digit;
            }

            Console.WriteLine(DigMax);
            Console.WriteLine(DigMin);
            Console.WriteLine(Math.Pow((DigMax - DigMin), 2));
            Console.ReadKey();
        }

        static void Divisors(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        static void DivisorsSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                }
                    
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static void DivisorsSumQnt(int n)
        {
            int sum = 0;
            int Qnt = 0;
            double Div = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Qnt = Qnt + 1;                    
                    Console.WriteLine(i);
                }
                Div = sum*1.0 / Qnt;
            }
            Console.WriteLine(Div);
            Console.ReadKey();
        }
        static int PowOfThree(int n)
        {            
            for (int i = 3; i < int.MaxValue; i*=3)
            {
                if (i == n)
                {
                    Console.WriteLine("{0} is a power of three",i);
                    return i;
                }
                if (i > n)
                    break;
            }
            Console.WriteLine("Entered number is not a power of three");
            return 0;           
           
        }
        static int PowOfTwo(int n)
        {
            for (int i = 2; i < int.MaxValue; i *= 2)
            {
                if (i < n)
                {
                    continue;
                }
                    
                {
                    if (i == 2)
                    {
                        Console.WriteLine(i);
                        return i;
                    }
                    {
                        Console.WriteLine(i / 2);
                        return i;
                    }
                }
                
            }
            Console.WriteLine("There is not such a number");
            return 0;
            
        }
        static void SumOfDig (int n)
        { 
             int Sum = 0;
            int InNumb = 0;
             for (int i = 1; n > 0; i++)
             {
                 InNumb = n;
                 int Digit = n % 10;
                 n = n / 10;
                 Sum += Digit;
            }
             if (InNumb == Sum*2)
                Console.WriteLine("Yes");
             else
                Console.WriteLine("No");
        }
        static void FourDigNumbCheck()
        {
            for (int i = 1000; i <= 9999; i++)
            {
                int Digit1 = i % 10;
                int Numb = i / 10;
                int Digit2 = Numb % 10;
                Numb /= 10;
                int Digit3 = Numb % 10;
                int Digit4 = Numb / 10;

                if (Digit1 != Digit2 && Digit2 != Digit3 && Digit3 != Digit4)
                {
                    if (Digit4 * 10 + Digit3 - (Digit2 * 10 + Digit1) == Digit1 + Digit2 + Digit3 + Digit4)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
}
}
