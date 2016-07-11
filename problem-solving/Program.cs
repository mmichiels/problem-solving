﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problem_solving
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static long SumArray(IEnumerable<int> arr)
        {
            ValidateArrayNotNull(arr);

            long arraySum = 0;
            foreach (var arrayInt in arr)
            {
                arraySum = arraySum + arrayInt;
            }
            return arraySum;
            //return arr.Sum();
        }

        public static long SumArrayOddValues(IEnumerable<int> arr)
        {
            ValidateArrayNotNull(arr);

            var oddValues = new List<int>();
            foreach (var arrayInt in arr)
            {
                if (arrayInt != 0 && arrayInt%2 != 0)
                {
                    oddValues.Add(arrayInt);
                }
            }

            return SumArray(oddValues.ToArray());
        }

        public static long SumArrayEverySecondValue(IEnumerable<int> arr)
        {
            ValidateArrayNotNull(arr);

            var everySecondValue = new List<int>();
            int count = 0;
            foreach (var arrayInt in arr)
            {
                if (count > 0 && count%2 != 0)
                {
                    everySecondValue.Add(arrayInt);
                }
                count++;
            }

            return SumArray(everySecondValue.ToArray());
        }

        public static IEnumerable<int> GetUniqueValues(IEnumerable<int> arr)
        {
            ValidateArrayNotNull(arr);
            var uniqueValues = new List<int>();

            foreach (var arrayInt in arr)
            {
                var matchingValues = new List<int>();
                matchingValues.AddRange(from duplicateInt in uniqueValues where duplicateInt == arrayInt select arrayInt);
                if (matchingValues.Count == 0)
                {
                    uniqueValues.Add(arrayInt);
                }
            }

            return uniqueValues;
        }

        public static IEnumerable<int> GetArrayIntersect(IEnumerable<int> arrA, IEnumerable<int> arrB)
        {
            ValidateArrayNotNull(arrA);
            ValidateArrayNotNull(arrB);

            var uniqueArrAValues = GetUniqueValues(arrA);
            var uniqueArrBValues = GetUniqueValues(arrB);
            var arrayIntersectValues = new List<int>();

            foreach (var arrayAInt in uniqueArrAValues)
            {
                var matchingValues = new List<int>();
                matchingValues.AddRange(from arrayBInt in uniqueArrBValues where arrayBInt == arrayAInt select arrayAInt);
                if (matchingValues.Count >= 1)
                {
                    arrayIntersectValues.Add(arrayAInt);
                }
            }

            return arrayIntersectValues;
        }

        public static IEnumerable<int> GetArrayNotIntersect(IEnumerable<int> arrA, IEnumerable<int> arrB)
        {
            // return an array that contains all the values that are in array A or array B but not in both array A and array B
            ValidateArrayNotNull(arrA);
            ValidateArrayNotNull(arrB);

            var combinesValues = arrA.ToList();
            combinesValues.AddRange(arrB.ToList());
            var uniqueValues = new List<int>();

            foreach (var arrayInt in combinesValues)
            {
                var matchingValues = new List<int>();
                matchingValues.AddRange(from duplicateInt in combinesValues where duplicateInt == arrayInt select arrayInt);
                if (matchingValues.Count < 2)
                {
                    uniqueValues.Add(arrayInt);
                }
            }

            return uniqueValues;
        }

        public static Boolean HasSum(IEnumerable<int> arr, long target)
        {
            // return true if any 2 values in the array have a sum equal to the target value
            // TODO
            return false;
        }

        public static long LoneSum(IEnumerable<int> arr)
        {
            // Given an array of int values, return their sum. 
            // However, if any of the values is the same as another of the values, it does not count towards the sum.
            return 0;
        }

        public static String DoubleString(String s)
        {
            // return a string that is the original string with each character in the string repeated twice
            // e.g. for input "ABCDE", return "AABBCCDDEE"
            return null;
        }

        public static int CountChars(String s, char c)
        {
            // return the count of how many times char c occurs in string s
            return 0;
        }

        public static long SumDigits(String s)
        {
            // return the sum of the digits 0-9 that appear in the string, ignoring all other characters
            // e.g. "123" return 6
            return 0;
        }

        public static long SumNumbers(String s)
        {
            // return the sum of the numbers that appear in the string, ignoring all other characters
            // a number is a series of 1 or more digits in a row
            // e.g. "11 22" returns 33
            return 0;
        }

        public static Boolean IsAnagram(String s1, String s2)
        {
            // return true if String s1 is an anagram of s2, otherwise return false
            // An anagram is produced by rearranging the letters of one string into another
            // e.g. care is an anagram of race
            // cat is not an anagram of rat
            return false;
        }

        public static int BlackJack(int count1, int count2)
        {
            // Given 2 integer values greater than 0, 
            // return whichever value is nearest to 21 without going over. 
            // Return 0 if they both go over.
            return 0;
        }

        public static int FivePlayerBlackJack(int count1, int count2, int count3, int count4, int count5)
        {
            // Given 5 integer values greater than 0, 
            // return whichever value is nearest to 21 without going over. 
            // Return 0 if they all go over.
            return 0;
        }

        public static int NPlayerBlackJack(IEnumerable<int> counts)
        {
            // Given a list of integer values greater than 0, 
            // return whichever value is nearest to 21 without going over. 
            // Return 0 if they all go over.
            return 0;
        }

        public static Dictionary<String, int> WordCount(IEnumerable<String> arr)
        {
            // Given an array of Strings, 
            // return a dictionary keyed on the string with the count of how many times each string appears in the array
            return null;
        }

        public static int Factorial(int n)
        {
            // Given n, return the factorial of n, which is n * (n-1) * (n-2) ... 1
            return 0;
        }

        public static List<String> FB(int n)
        {
            // Given n, print the numbers from 1 to n as a string to a List of strings, with the following exceptions:
            // If the number is divisable by 3, replace it with the word "Fizz"
            // If the number is divisable by 5, replace it with the word "Buzz"
            // If the number is divisable by both 3 and 5, replace it with the word "FizzBuzz"
            return null;
        }

        public static void ValidateArrayNotNull(IEnumerable<int> arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("arr");
            }           
        }
    }
}
