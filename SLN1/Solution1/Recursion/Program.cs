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
            Test();


            int[] B = { 2, -1, 5, 6, 8, 9, -1, 10, 9 };
            int[] b = sortByHeight(B);
            Console.ReadKey();

            Lucky();

            //Intersect();


            string[] inputArray = { "aaa", "bbb", "cc", "45689" };
            allLongestStrings(inputArray);
            Console.ReadKey();


            int[,] matrix = new int[3, 4]

            {

                //0  1  2

                { 1, 5 , 0 , 4},//0

                { 5, 5 , 1 , 0},//1

                { 0, 0 , 2 , 3} //2

            };

            //Console.WriteLine(Sum(matrix));
            //Console.ReadKey();


            int[] myArray7 = { 1, 2, 3, 4, 3, 6};
            Console.WriteLine(almostIncreasingSequence7(myArray7)); 
            Console.ReadKey();
            

            int[] myArray4 = { 3, 1};
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
        
        
        static void Dinamic()
        {
            string[] strArray = new string[]
            { "Mahesh Chand", "Mike Gold", "Raj Beniwal", "Praveen Kumar", "Dinesh Beniwal" };
            strArray = new string [] {"A","B"};
        }

        //static bool almostIncreasingSequence5(int[] sequence)
        //{
        //    for (int i = sequence.Length-1, n = 0; n < i ; i--, n++)
        //    {
                

        //    }
            
        //}

        static bool almostIncreasingSequence7(int[] sequence)
        {
            int Qnt = 0;
            for (int i = 0; i <= sequence.Length - 2; i++)
            {
                if (sequence[i] >= sequence[i+1])
                {
                    Qnt += 1;
                    if (Qnt > 1) return false;
                    if (i != 0 && sequence[i - 1] >= sequence[i + 1]&& i != sequence.Length - 2 && sequence[i ] >= sequence[i + 2])
                        return false;
                    else
                        continue;
                }
                else 
                {
                    continue;
                }
                
            }
            return Qnt <= 1;
        }

        //static int Sum (int[ , ] matrix)
        //{
        //    int Summ = 0;
        //    for (int j = 0; j < matrix.Length; j++)
        //    {
        //        for (int i = 0; i < matrix.Length; i++)
        //        {
        //            if (matrix[i , j] <= 0)
        //            {
        //                break;
        //            }
        //            else
        //                Summ += matrix[i  j];
        //        }
        //    }
        //    return Summ;
        //}

        static void allLongestStrings(string[] inputArray)
        {
            //int maxLength = inputArray.Max(i => i.Length);
            //string[] longestStrings = inputArray.Where(i => i.Length == maxLength).ToArray();
            int max = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                max = Math.Max(max , inputArray[i].Length);
            }
            string[] longest = inputArray.Where(i => i.Length == max).ToArray();

        }

        //static void Intersect()
        //{
        //    string AA = "ABCDAA";
        //    AA = AA.Distinct().ToString();
        //    char[] AACH = AA.ToCharArray();
        //    char[] intersectChar = AA.Intersect(AA).ToArray();

        //    string[] list1 = { "a", "b", "c", "a" };
        //    string[] list2 = { "a", "a" , "b" };
        //    string[] intersectlist = list1.Except(list2).ToArray();
        //    var Newlist = list1.ToList();
        //    Newlist.Remove(intersectlist.Take);


            //list1.ToList();
            //list1.Except(new string[] { "c" }).ToArray();
            //return s1.Distinct().Sum(x => Math.Min(s1.Count(l => l == x), s2.Count(l => l == x)));
        //}


        //For n = 1230, the output should be
        //isLucky(n) = true;
        //For n = 239017, the output should be
        //11233 11233
        static bool Lucky ()
        {
            int n = 999999;
            int Sum1 = 0;
            int Sum2 = 0;
            int Qnt = n.ToString().Length;

            for (double i = Math.Pow(10, Qnt-1), j = 10; i >= j; i /= 100 )
            {
                Sum1 += n / Convert.ToInt32(i);
                Sum2 += n % Convert.ToInt32(j);
                n = (n % Convert.ToInt32(i)) / 10;
            }

            
            return Sum1 == Sum2;

        }


        //             var a = new List<int>();
        //         while (n != 0)
        //       {
        //             a.Insert(0, n % 10);
        //                n = n / 10;
        //          }
        //             var c = a.ToArray();
        //         for (int i = 0; i<c.Length; i++)
        //               if (i<c.Length / 2) sum1 = sum1 + c[i];
        //             else sum2 = sum2 + c[i];
        //       if (sum1 == sum2) return true;

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
        static void Delete()
        {
            int[] numbers = { 1, 3, 5, 4, 9, 2, 4, 5 };

            numbers = numbers.Except(new int[] { 4 }).ToArray();
            

            numbers = numbers.Distinct().ToArray();


        }
        static void Sequence()
        {
            int[] a = { 2, -1, 5, 6, 8, 9, -1, 10, 9};
            int [] sorted = (from element in a orderby element ascending select element).ToArray();
            var Numlist = a.ToList();
            var finalList = new List<int>();
            // Numlist.Remove(-1);

            for (int i = 0, j = 0; i < a.Length; i++, j++)
            {
                if (a[i] != -1)
                {                    
                    finalList.Add(sorted[j]);
                }
                else
                {
                    finalList.Add(a[i]);
                    j--;
                }                   
            }

            Console.ReadKey();
            
            
        }
        static int[] sortByHeight(int[] a)
        {
            int[] sorted = (from element in a orderby element ascending select element).ToArray();
            var finalList = new List<int>();

            for (int i = 0, j = 0; i < a.Length; i++, j++)
            {
                if (a[i] != -1)
                {
                    if (j < sorted.Length && sorted[j] == -1)
                        for (j++ ; j < sorted.Length; j++)
                    {
                            if (sorted[j] == -1)
                                continue;
                            else break;
                    }
                    
                    finalList.Add(sorted[j]);
                }
                else
                {
                    finalList.Add(a[i]);
                    j--;
                }
            }
            return finalList.ToArray();

        }
        static void Test()
        {
            string AA = "AAACCBVVVV";
            Char T = AA.ElementAt(0);
            int qnt = 1;
            string TEST = string.Empty;
            for (int i = 1; i < AA.Length; i++)
            {
                if (AA.ElementAt(i) == T )
                {
                    qnt += 1;
                    continue;
                }
                {
                    TEST = TEST + qnt + T;
                    T = AA.ElementAt(i);
                    qnt = 1;
                }
            }
            TEST = TEST +qnt + T;
            Console.ReadKey();
        }
    }
}
