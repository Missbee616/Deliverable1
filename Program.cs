using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Deliverable1
{

    //A program to read two integers from the user and check if 
    //corresponding place in the two numbers sums to the same total

    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = "";
            string secondNumber = "";

            Console.Write("Enter any number: ");
            firstNumber = Console.ReadLine();

            // if firstNumber is a valid integer

            int firstNumberInt = 0;
            bool result1 = int.TryParse(firstNumber, out firstNumberInt);

            if
                (result1 == false)
            {
                Console.WriteLine(firstNumber + " is not a valid number. Please enter a valid number: ");
                Console.Write("Enter any number: ");
                firstNumber = Console.ReadLine();
            }
            else
            {
                Console.Write("Enter another number with the same number of digits: ");
                secondNumber = Console.ReadLine();

                // if secondNumber is a valid integer

                int secondNumberInt = 0;
                bool result2 = int.TryParse(secondNumber, out secondNumberInt);

                if (result2 == false)

                    Console.WriteLine(secondNumber + " is not a valid number. Please enter a valid number: ");
                else
                    Console.WriteLine("First Number is " + firstNumberInt + ", Second Number is " + secondNumberInt);

                // if firstNumbercount and secondNumbercount are equal
                if (firstNumber.Length == secondNumber.Length)

                    Console.WriteLine("Numbers are the same length");

                else
                    Console.WriteLine("Numbers must be the same length");

            }
            //Substring
            int n = 0;
            int[] sumArray = new int[firstNumber.Length];

            while (n < firstNumber.Length)
            {
                //Console.WriteLine("Current value of n is {0}", n);

                //Create array for first input
                string[] nums1 = new string[firstNumber.Length];
                nums1[n] = firstNumber.Substring(n, 1);

                //Console.WriteLine("Num 1 is " + nums1[n]);

                int nums1Int = 0;
                bool nums1result = int.TryParse(nums1[n], out nums1Int);

                //Console.WriteLine("nums1Int = " + nums1Int);

                //Create array for second input
                string[] nums2 = new string[secondNumber.Length];
                nums2[n] = secondNumber.Substring(n, 1);

                //Console.WriteLine("Num 2 is " + nums2[n]);

                int nums2Int = 0;
                bool nums2result = int.TryParse(nums2[n], out nums2Int);

                //Console.WriteLine("nums2Int = " + nums2Int);

                //Sum Test
                int sum1 = nums1Int + nums2Int;

                sumArray[n] = sum1;

                //Console.WriteLine("Sum is " + sumArray[n]);

                //Console.WriteLine("sumArray length is " + sumArray.Length);
                n++;
            }

            //int[] ray = { 7, 7, 7 };
            {
                int i = 0;
                bool match = true;
                while (i < sumArray.Length)
                {
                    if (sumArray[0] == sumArray[i])

                    {
                        Console.WriteLine("So far so good");
                    }
                    else
                    {
                        match = false;
                    }
                     Console.WriteLine(sumArray[0] + "and" + sumArray[i]);
                     i++;
                }
                Console.WriteLine("Match = " + match);
            }
                        }
        }
    }


