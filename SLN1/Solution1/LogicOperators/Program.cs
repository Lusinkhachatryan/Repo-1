using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Task 1
            //Console.Write("Enter 2 numbers->");
            //int Number1 = int.Parse(Console.ReadLine());
            //int Number2 = int.Parse(Console.ReadLine());
            //int Rem1 = Number1 % 2;
            //int Rem2 = Number2 % 2;
            //// a) 
            //if (Rem1 != 0 && Rem2 != 0)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}
            //Console.ReadKey();
            ////b)
            //if (Rem1 != 0 || Rem2 != 0)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}
            //Console.ReadKey();
            ////c)
            //if ((Rem1 != 0 || Rem2 != 0) && !(Rem1 != 0 && Rem2 != 0))

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();

            ////d)
            //if (!((Rem1 != 0 || Rem2 != 0) && !(Rem1 != 0 && Rem2 != 0))) // or (Rem1 != 0 && Rem2 != 0) || (Rem1 == 0 && Rem2 == 0)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();

            ////Task 2
            //Console.Write("Enter 3 numbers->");
            //int Number1 = int.Parse(Console.ReadLine());
            //int Number2 = int.Parse(Console.ReadLine());
            //int Number3 = int.Parse(Console.ReadLine());

            ////a)
            //if (Number1 > 0 && Number2 > 0 && Number3 > 0)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////b)
            //if (!(Number1 < 0 && Number2 < 0 && Number3 < 0))// or (Number1 > 0 || Number2 > 0 || Number3 > 0)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////c)
            //if ((Number1 * Number2 * Number3 > 0) && !(Number1 > 0 && Number2 > 0 && Number3 > 0))

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////d)
            //if ((Number1 * Number2 * Number3 < 0) && !(Number1 < 0 && Number2 < 0 && Number3 < 0))

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();

            ////e)
            //if (!(Number1 != Number2 && Number2 != Number3 && Number1 != Number3))

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////f)
            //int N1Abs = Math.Abs(Number1);
            //int N2Abs = Math.Abs(Number2);
            //int N3Abs = Math.Abs(Number3);
            //if (!(N1Abs != N2Abs && N2Abs != N3Abs && N1Abs != N3Abs))

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();

            ////Task 3
            //Console.Write("Enter a numbers->");
            //int Number1 = int.Parse(Console.ReadLine());
            //int Cond1 = Number1 % 2;
            //int Cond2 = Number1 / 10;
            //int Cond3 = Number1 / 100;
            ////a)
            //if (Cond1 == 0 && Cond2 > 0 && Cond2 < 10)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            //b)
            //if (Cond1 != 0 && Cond3 > 0 && Cond3 < 10)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////Task4
            //Console.Write("Enter a 3 digit number->");
            //int Number1 = int.Parse(Console.ReadLine());
            //int Dig1 = Number1 % 10;
            //int Dig2 = Number1 /10 % 10;
            //int Dig3 = Number1 / 100;

            ////a)
            //if (Dig1 != Dig2 && Dig2 != Dig3 && Dig1 != Dig3)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////b)
            //if (Dig1 > Dig2 && Dig2 > Dig3)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////c)
            //if (Dig1 == Dig3)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();

            ////Task5
            //Console.Write("Enter 2 numbers->");
            //int Coordx = int.Parse(Console.ReadLine());
            //int Coordy = int.Parse(Console.ReadLine());
            ////a)
            //if (Coordx < 0 && Coordy > 0)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////b)
            //if (Coordx > 0 && Coordy < 0)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////c)
            //if (Coordx < 0 && Coordy != 0)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////d)
            //if (Coordx < 0 && Coordy < 0 || Coordx > 0 && Coordy > 0)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();

            ////Task6
            //Console.Write("Enter 6 numbers->");
            //int X1 = int.Parse(Console.ReadLine());
            //int Y1 = int.Parse(Console.ReadLine());
            //int X2 = int.Parse(Console.ReadLine());
            //int Y2 = int.Parse(Console.ReadLine());
            //int X = int.Parse(Console.ReadLine());
            //int Y = int.Parse(Console.ReadLine());

            //if (X > X1 && X < X2 && Y > Y2 && Y<Y1)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();
            ////Task7
            //Console.Write("Enter 3 numbers->");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a + b > c && b + c > a && a + c > b)

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();

            ////Task8
            //Console.Write("Enter 3 numbers->");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if (a + b > c && b + c > a && a + c > b)
            //{
            //    //a)

            //    if (a == b && b == c && a == c)

            //        {

            //            Console.WriteLine("Yes");

            //        }
            //        else

            //        {

            //            Console.WriteLine("No");

            //        }
            //    //b)

            //    if (!(a != b && b != c && a != c))

            //    {

            //        Console.WriteLine("Yes");

            //    }
            //    else

            //    {

            //        Console.WriteLine("No");

            //    }
            //    //c)

            //    if (Math.Pow(a,2) == Math.Pow(b, 2) + Math.Pow(c, 2) 
            //        || Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)
            //        || Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))

            //    {

            //        Console.WriteLine("Yes");

            //    }
            //    else

            //    {

            //        Console.WriteLine("No");

            //    }
            //}

            //Console.ReadKey();
            ////Task9
            //Console.Write("Enter 2 numbers->");
            //int X = int.Parse(Console.ReadLine());
            //int Y = int.Parse(Console.ReadLine());
            //int Cond1 = X % 2;
            //int Cond2 = Y % 2;

            //if (Cond1 == 0 && Cond2 == 0 || Cond1 != 0 && Cond2 != 0)

            //{

            //    Console.WriteLine("black");

            //}
            //else

            //{

            //    Console.WriteLine("white");

            //}

            //Console.ReadKey();

            ////Task10
            //Console.Write("Enter 2 numbers->");
            //int X1 = int.Parse(Console.ReadLine());
            //int Y1 = int.Parse(Console.ReadLine()); 
            //int CondX1 = X1 % 2;
            //int CondY1 = Y1 % 2;
            //int X2 = int.Parse(Console.ReadLine());
            //int Y2 = int.Parse(Console.ReadLine());
            //int CondX2 = X2 % 2;
            //int CondY2 = Y2 % 2;

            //if ((CondX1 == 0 && CondY1 == 0 || CondX1 != 0 && CondY1 != 0) 
            //    && (CondX2 == 0 && CondY2 == 0 || CondX2 != 0 && CondY2 != 0))

            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");

            //}

            //Console.ReadKey();

            ////Task11
            //Console.Write("Enter 3 numbers->");
            //int Number1 = int.Parse(Console.ReadLine());
            //int Number2 = int.Parse(Console.ReadLine());
            //int Number3 = int.Parse(Console.ReadLine());
            ////a)
            //if (Number1 < Math.Min(Number2,Number3))

            //{

            //    Console.WriteLine(Number1);

            //}
            //else

            //{

            //    Console.WriteLine(Math.Min(Number2, Number3));

            //}

            //Console.ReadKey();

            ////b)
            //if (Number1 < Math.Min(Number2, Number3))

            //{

            //    Console.WriteLine(Math.Min(Number2, Number3));

            //}
            //else

            //{

            //    Console.WriteLine(Number1);

            //}

            //Console.ReadKey();

            ////c)
            //if (Number1 < Math.Min(Number2, Number3))

            //{

            //    Console.WriteLine(Number2 + Number3);

            //}
            //else

            //{

            //    Console.WriteLine(Number1 + Math.Max(Number2,Number3));

            //}

            //Console.ReadKey();

            ////Task12
            //Console.Write("Enter 3 numbers->");
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());

            //if ((A > B && B > C) || (A < B && B < C))

            //{

            //    Console.WriteLine(A * 2);
            //    Console.WriteLine(B * 2);
            //    Console.WriteLine(C * 2);

            //}
            //else

            //{

            //    Console.WriteLine(A * -1);
            //    Console.WriteLine(B * -1);
            //    Console.WriteLine(C * -1);

            //}

            //Console.ReadKey();

            ////Task13
            //Console.Write("Enter 3 numbers->");
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());

            //if ((Math.Abs(B) - Math.Abs(A)) < (Math.Abs(C) - Math.Abs(A)))

            //{

            //    Console.WriteLine(B);
            //    Console.WriteLine(Math.Abs(A) - Math.Abs(B));

            //}
            //else

            //{

            //    Console.WriteLine(C);
            //    Console.WriteLine(Math.Abs(A) - Math.Abs(C));

            //}

            //Console.ReadKey();

            ////Task14
            //Console.Write("Enter 3 numbers->");
            //int X = int.Parse(Console.ReadLine());
            //int Y = int.Parse(Console.ReadLine());

            //if ( X == 0 && Y == 0)

            //{

            //    Console.WriteLine(0);              

            //}
            //else if (X == 0 && Y != 0)

            //{

            //    Console.WriteLine(1);              

            //}
            //else if (Y == 0 && X != 0)

            //{

            //    Console.WriteLine(2);

            //}
            //else 

            //{

            //    Console.WriteLine(3);

            //}
            //Console.ReadKey();

            ////Task15
            //Console.Write("Enter 3 numbers->");
            //int X = int.Parse(Console.ReadLine());
            //int Y = int.Parse(Console.ReadLine());

            //if (X > 0 && Y > 0)

            //{

            //    Console.WriteLine("I");


            //}
            //else if(X < 0 && Y > 0)

            //{

            //    Console.WriteLine("II");


            //}
            //else if (X < 0 && Y < 0)

            //{

            //    Console.WriteLine("III");


            //}
            //else 

            //{

            //    Console.WriteLine("IV");


            //}
            //Console.ReadKey();
            ////Task16
            //Console.Write("Enter 2 numbers->");
            //float X = float.Parse(Console.ReadLine());
            //float Y = float.Parse(Console.ReadLine());

            //if (X < 0 && Y < 0 && (X + Y) == -1)
            //{

            //    Console.WriteLine("Yes");

            //}
            //else

            //{

            //    Console.WriteLine("No");


            //}
            //Console.ReadKey();

            ////Task17
            //Console.Write("Enter 6 numbers->");
            //int X1 = int.Parse(Console.ReadLine());
            //int Y1 = int.Parse(Console.ReadLine());
            //int X2 = int.Parse(Console.ReadLine());
            //int Y2 = int.Parse(Console.ReadLine());
            //int X3 = int.Parse(Console.ReadLine());
            //int Y3 = int.Parse(Console.ReadLine());

            //if ((X1 - X2) == 0)
            //{

            //    Console.WriteLine(X3);

            //}
            //else if ((X1 - X3) == 0)

            //{

            //    Console.WriteLine(X2);

            //}
            //else 

            //{

            //    Console.WriteLine(X1);

            //}

            //if ((Y1 - Y2) == 0)
            //{

            //    Console.WriteLine(Y3);

            //}
            //else if ((Y1 - Y3) == 0)

            //{

            //    Console.WriteLine(Y2);

            //}
            //else

            //{

            //    Console.WriteLine(Y1);

            //}
            //Console.ReadKey();
            ////Task18
            //Console.Write("Enter a number->");
            //int n = int.Parse(Console.ReadLine());
            //int miavor = n % 10;
            //int haryur = n / 100;
            //if ((miavor - 3) == haryur)
            //{

            //    Console.WriteLine(1);

            //}
            //else

            //{

            //    Console.WriteLine(Math.Pow(n,2));

            //}
            //Console.ReadKey();

            //Task19
            Console.Write("Enter a number->");
            int n = int.Parse(Console.ReadLine());
            int Rem = n % 3;
            int Num = n / 3;

            if (Rem == 1)
            {
                int Num2 = n - Rem - 3*3;
                int a = Num2 / 3;
                int b = (Rem + 3*3) / 5;


                Console.WriteLine("3*" + a +"+"+ "5*" + b + "=" + n);

            }
            else if(Rem == 2)

            {
                int Num2 = n - Rem - 3;
                int a = Num2 / 3;
                int b = (Rem + 3) / 5;

                Console.WriteLine("3*" + a + "+" + "5*" + b + "=" + n);

            }
            else 

            {
                int a = n / 3;
                int b = 0;

                Console.WriteLine("3*" + a + "+" + "5*" + b + "=" + n);

            }
            Console.ReadKey();



        }
    }
}
