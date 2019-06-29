using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray7 = { 3, 1};
            Console.WriteLine(IncreasingSequence(myArray7));
            Console.ReadKey();

            Console.WriteLine(checkPalindrome("madam"));
            Console.ReadKey();

            DeleteFromList();
            Console.ReadKey();

            int[] myArray = { 1, 1, 2, 3, 4 };
            IncreasingSequence(myArray);
            Console.ReadKey();

            int[] myArray2 = { 1, 1, 2, 3, 4, 4 };
            Console.WriteLine(almostIncreasingSequence1(myArray));
            Console.ReadKey();

            Console.WriteLine(makeArrayConsecutive2(myArray));
            Console.ReadKey();

            Console.WriteLine(shapeArea(3));
            Console.ReadKey();

            Console.WriteLine(palindrome("asdsa"));
            Console.ReadKey();

            int[] myArray1 = { 1, 20, 50, 30, 70, 10, 90 };
            adjacentElementsProduct(myArray);


            var A = myArray.Select(element => element.ToString());
            Console.WriteLine(A.GetType());
            Math.Max(1, 1);
            Console.WriteLine(maxProduct(myArray));
            Console.ReadKey();

        }
        static bool checkPalindrome(string input, int i = 0)
        {
            char[] output = input.ToCharArray();
            int lenght = input.ToCharArray().Length;
            if (i > lenght / 2)
            {
                return true;
            }
            {
                if (output[i] != output[lenght - i - 1])
                    return false;
                checkPalindrome(input, ++i);
            }
            return true;

        }
        static bool palindrome(string inpt)
        {
            return inpt.SequenceEqual(inpt.Reverse());
        }
        int centuryFromYear(int year)
        {
            int rem = year % 100;

            if (rem > 0)
            {
                return year / 100 + 1;
            }
            {
                return year / 100;
            }
            
        }

        static int maxProduct(int[] arr)
        {
            int Prod = arr[0] * arr[1];
            for (int i = 1; i <= arr.Length - 2;)
            {
                Prod = Math.Max(Prod, arr[i] * arr[1 + i++]);

            }

            return Prod;

        }
        static int adjacentElementsProduct(int[] inputArray)
        {
            return inputArray.Select((i, j) => j > 0 ? i * inputArray[j - 1] : int.MinValue).Max();

        }
        static int shapeArea(int n)
        {
            int Area = 1;
            for (int i = 2; i <= n; i++)

            {

                Area += (i - 1) * 4;
            }
            return Area;

        }
        static int makeArrayConsecutive2(int[] statues)
        {
            int Qnt = 0;
            Array.Sort(statues);
            for (int i = 0; i < statues.Length - 1; i++)
            {
                Qnt += statues[i + 1] - statues[i] - 1;
            }
            return Qnt;
        }

        static bool almostIncreasingSequence(int[] sequence)
        {
            if (sequence.Length == 1) return true;

            if (sequence[sequence.Length - 1] - sequence[sequence.Length - 2] > 0)
            {
                if (sequence.Length >= 2)
                {
                    sequence = sequence.Take(sequence.Length - 1).ToArray();
                    almostIncreasingSequence(sequence);
                }

            }

            return false;



        }
        //void method with CW dest work properly either
        static bool IncreasingSequence(int[] sequence)
        {
            if (sequence.Length == 1)
            {
                return true;
            }
            else
            {
                if (sequence[sequence.Length - 1] - sequence[sequence.Length - 2] > 0)
                {
                    if (sequence.Length >= 2)
                    {
                        sequence = sequence.Take(sequence.Length - 1).ToArray();
                        IncreasingSequence(sequence);
                        
                    }
                    return true;
                }
                else
                {
                    return false;

                }
            }
            
        }
        static bool almostIncreasingSequence1(int[] sequence)
        {
            int Qnt = 0;

            for (int i = sequence.Length - 1; i >= 2; i--)
            {
                if (sequence[i] - sequence[i - 2] <= 0 && sequence[i] - sequence[i - 1] <= 0)
                    Qnt += 2;
                else if (sequence[i] - sequence[i - 2] <= 0 || sequence[i] - sequence[i - 1] <= 0)
                    Qnt += 1;
            }
            return sequence[1] - sequence[0] <= 0 ? (Qnt + 1) <= 1 : Qnt <= 1;
        }

        //delete an element from an array by value
        static void Delete()
        {
            int[] numbers = { 1, 3, 5, 4, 9, 2, 4 , 5};

            numbers = numbers.Except(new int[] { 4 }).ToArray();
            numbers = numbers.Distinct().ToArray();
                                

        }
        //delete an element from an ArrayList  
        static void DeleteFromList()
        {
            int[] numbers = { 1, 3, 4, 9, 2, 4 };
            var numbersList = numbers.ToList();
            numbersList.RemoveAt(4);
            numbersList.Remove(4);
            Console.WriteLine(numbersList);
            foreach (int item in numbersList)
            {
                Console.Write(item);
            }

        }
    }
}
