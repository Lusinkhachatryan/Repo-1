using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            ////task 1 
            //Console.Write("Enter a 4 digit number->");
            //int Number = int.Parse(Console.ReadLine());
            //int Sum = 0;
            //for(int i = 1; Number > 0; i++)
            //{
            //    int Digit = Number % 10;
            //    Number = Number / 10;
            //    Sum += Digit;
            //}
            //Console.WriteLine(Sum);
            //Console.ReadKey();

            ////task 2
            //Console.Write("Enter K and N (N>0)->");
            //int K = int.Parse(Console.ReadLine());
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    Console.WriteLine(K);
            //}

            //Console.ReadKey();

            ////task 3
            //Console.Write("Enter a 1 digit number");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = ++n; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();

            ////task 4
            //Console.Write("Enter a number");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(Math.Pow(n,i));
            //}

            //Console.ReadKey();

            ////task 5
            //Console.Write("Enter a number");
            //int n = int.Parse(Console.ReadLine());
            //int Sum = 0;

            //for (int i = 2; i < n; i+=2)
            //{
            //    Sum = Sum + i;
            //}
            //Console.WriteLine(Sum);
            //Console.ReadKey();

            ////task 6
            //Console.WriteLine("Enter A and B");
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int i;
            //for ( i = A; i <= B; i++)
            //{

            //    Console.WriteLine(i);

            //}
            //Console.WriteLine(i - A);
            //Console.ReadKey();

            ////task 7
            //Console.WriteLine("Enter A and B");
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int Sum = 0;
            //for (int i = A; i <= B; i++)
            //{

            //    Sum += i;

            //}
            //Console.WriteLine(Sum);
            //Console.ReadKey();

            ////task 8
            //Console.WriteLine("Enter A and B");
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int Number;
            //string Output = "Not found";
            //for (int i = A; i <= B; i++)
            //{
            //    Number = i % 3;
            //    if (Number == 0)
            //    {
            //        Output = " " + i;
                   
            //    }

            //    if (Number == 0) break;

            //}
            //Console.WriteLine(Output);
            //Console.ReadKey();


            ////task 9
            //Console.WriteLine("Enter a number");
            //int N = int.Parse(Console.ReadLine());
            //double Sum = 1;

            //for (int i = 2; i <= N; i++)
            //{

            //    Sum = Sum + 1.0 / i;

            //}
            //Console.WriteLine(Sum);
            //Console.ReadKey();

            ////task 10 
            //Console.WriteLine("Enter a number");
            //int N = int.Parse(Console.ReadLine());
            //double Sum = Math.Pow(N, 2);
            //for (int i = 1; i <= N; i++)
            //{
            //    Sum = Sum + Math.Pow((N + i), 2);
            //}
            //Console.WriteLine(Sum);
            //Console.ReadKey();


            //for (int i = 2; i <= N; i++)
            //{

            //    Sum = Sum + 1.0 / i;

            //}
            //Console.WriteLine(Sum);
            //Console.ReadKey();

            ////task 11
            //Console.WriteLine("Enter a number");
            //int N = int.Parse(Console.ReadLine());
            //double Sum = 1.1;

            //for (double i = 1; i <= N; i++)
            //{

            //    Sum = Sum *(Sum + 0.1);

            //}
            //Console.WriteLine(Sum);
            //Console.ReadKey();
            ////task 12
            //Console.WriteLine("Enter a number");
            //int N = int.Parse(Console.ReadLine());
            //double Sum = 1.1;
            //double n = -1;
            //double m = 0.1;

            //for (double i = 1; i < N; i++)
            //{

            //    Sum = Sum + (1.1 + m) * n;
            //    n *= -1;
            //    m += 0.1;
            //}
            //Console.WriteLine(Sum);
            //Console.ReadKey();

            ////task 13
            //Console.WriteLine("Enter a number");
            //int N = int.Parse(Console.ReadLine());
            //int Sum = 0;

            //for (int i = 1; i <= N; i ++)
            //{

            //    Sum = Sum + (2*i -1);
            //    Console.WriteLine(Sum);
            //}           
            //Console.ReadKey();

            ////task 14
            //Console.WriteLine("Enter a number");
            //int N = int.Parse(Console.ReadLine());
            //int Sum = 0;
            //int NRem = N;
            //do
            //{

            //    int Digit = NRem % 10;
            //    NRem /= 10;
            //    Sum += Digit;
            //} while(NRem > 0);
            //if (N == 2 * Sum)
            //{
            //    Console.WriteLine("Yes");

            //}
            //{
            //    Console.WriteLine("No");

            //}
            //    Console.ReadKey(); 

            //// Task 14.1  // Find 2 and 3 digit numbers that meet the conditions given in the Task 14 

            //int A, B, C;
            //for (A = 1; A < 10; A++)
            //{
            //    for (B = 1; B < 10; B++)
            //    {
            //        if (10 * A + B == 2 * A + 2 * B)

            //        {
            //            Console.WriteLine("{0} {1}", A, B);
            //        }
            //        for (C = 1; C < 10; C++)
            //            if (100 * A + 10 * B + C == 2 * A + 2 * B + 2 * C)

            //            {
            //                Console.WriteLine("{0} {1}", A, B);
            //            }

            //    }
            //}

            //Console.ReadKey();

            ////task 15
            //Console.WriteLine("Enter a number for ex. 7");
            //int n = int.Parse(Console.ReadLine());
            //int ABC, B, C;
            //for (C = 0; C < 10; C++)
            //{
            //    int Numb1 = C * n;
            //    if(Numb1 % 10 == C)
            //    {
            //        int Rem1 = Numb1 / 10;
            //        for (B = 1; B < 10; B++)
            //        {
            //            int Numb2 = B * n;
            //            if ((Numb2 + Rem1) % 10 == B)
            //            {
            //                ABC = (Numb2 + Rem1) * 10 + C;
            //                Console.WriteLine(ABC);
            //            }
            //        }
            //    }

            //}


            //    Console.ReadKey();





        }
    }
}
