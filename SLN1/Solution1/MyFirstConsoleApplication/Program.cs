using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            CheckList("DAABCB", "BAABCD");
            Console.ReadKey();
            int A1 = 895;
            char[] NumToString = A1.ToString().ToCharArray();
            List < char > AA = NumToString.Distinct().ToList();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

       //static void Sum ( string s1, string s2)
       // {
       //     //string N = n.ToString();
       //     //char[] distinctNums = N.Distinct().ToArray();
       //     List<string> t = s1.Distinct().ToList<>;
            
       //         if (s1.Count(l => l == "b") == s2.Count(l => l == "b"))
       //     {
       //         int A = 22;
       //     }
       //     ;
       //     var B = s1.Count(a => a == 7 );

       // }

        static bool CheckList(string Num1 , string Num2)
        {
            
            char [] DistNum1 = (Num1+Num2).Distinct().ToArray();

            for (int i = 0; i <= DistNum1.Length - 1; i++)
            {
                int cnt = 0;
                foreach (char c in Num1)
                {
                    if (c == DistNum1[i])
                    {
                        cnt++;
                    }
                  
                }

                foreach (char c in Num2)
                {
                    if (c == DistNum1[i])
                    {
                        cnt--;
                    }
                }
                if (cnt == 0) continue;
                else
                    Console.WriteLine("-");
                    return false;
            }
            Console.WriteLine("+");
            return true;


            //if (Num1.Distinct().Count() != Num2.Distinct().Count())
            //{
            //    return false;
            //}
            //for (int i = 0; i <= Num1.Distinct().Count(); i++)
            //{
            //    if (Num1.Distinct().Count(A => Num1.Select(B => B == A))
            //    {

            //    }
            //}

            //return Num1.Distinct().Sum(A => Num1.Count(B => B == A)) ==



        }

        static void Valid()
        {
            Stack<char> S = new Stack<char>();
            S.Peek
        }



    }
}
