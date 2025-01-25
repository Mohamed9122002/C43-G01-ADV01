using AssignmentSession01C_Advanced.Question01;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using AssignmentSession01C_Advanced.Question02;
using System.Collections.Generic;
using System.Numerics;
using AssignmentSession01C_Advanced.Question03;
using AssignmentSession01C_Advanced.Question04;
using System.Runtime.Intrinsics.X86;
using System;

namespace AssignmentSession01C_Advanced
{
    internal class Program
    {
        public static int FindFirstNotChar(string str)
        {
            if (str is null) return -1;
            
            int[] ints = new int[256];

            foreach (char c in str)
            {
                ints[c]++;
            }
            for(int i = 0; i < str.Length; i++)
            {
                if (ints[str[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
        static void Main(string[] args)
        {

            #region Question01
            //Create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.
            //The range should support basic operations such as checking if a value is within the range and determining the length of the range.

            //Range<int> intRange = new Range<int>(20, 10);
            //Console.WriteLine($"Range Length (int): {intRange.Length()}"); 
            //Console.WriteLine($"Is 15 in range: {intRange.IsRange(15)}");  
            //Console.WriteLine($"Is 25 in range: {intRange.IsRange(25)}");

            #endregion
            #region Question02
            //You are given an ArrayList containing a sequence of elements. try to
            //reverse the order of elements in the ArrayList in-place(in the same
            //arrayList) without using the built-in Reverse.Implement a function that
            //takes the ArrayList as input and modifies it to have the reversed order of
            //elements.
            // int[] intArray = { 1, 2, 3, 4, 5 };

            // Console.WriteLine("Original Array:");
            // foreach (int item in intArray)
            // {
            //     Console.Write(item + " ");
            // }
            //ArrayListReverser<int>.ReverseArrayList(intArray);

            // Console.WriteLine("\nReversed Array:");
            // foreach (int item in intArray)
            // {
            //     Console.Write(item + " ");
            // }
            //double[] doubles = { 1.1, 2.2, 3.3, 4.4, 5.5 };

            //Console.WriteLine("Original Array:");
            //foreach (double item in doubles)
            //{
            //    Console.Write(item + " ");
            //}
            //ArrayListReverser<double>.ReverseArrayList(doubles);

            //Console.WriteLine("\nReversed Array:");
            //foreach (double item in doubles)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region Question03
            //You are given a list of integers.Your task is to find and return a new list
            //    containing only the even numbers from the given list.
            //int[] inputArray = { 1, 2, 3, 4, 5, 6, 7 };

            //int[] evenArray = NewListEven<int>.ArraryListEven(inputArray);

            //Console.WriteLine("Original Array:");
            //foreach (var item in inputArray)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\nArray with even indices:");
            //foreach (var item in evenArray)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion
            #region Question04
            //FixedSizeList<int> list = new FixedSizeList<int>(3);
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);

            //Console.WriteLine(list.GetIndex(1));

            #endregion
            #region Question 05
            //Given a string, find the first non-repeated character in it and return its 
            //index.If there is no such character, return -1.Hint you can use dictionary
            string str = "mmo";
            Console.WriteLine(FindFirstNotChar(str));
            #endregion
        }
    }
}
