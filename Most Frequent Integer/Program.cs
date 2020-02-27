/*
Author: Thomas Williams
Descritpion:
    Given an array of integers, find the most frequent integer.
    Write a method that takes an array of integers and returns an integer
*/


using System;
using System.Collections.Generic;

namespace Job_Enterview_Questions
{
    class Program
    {
        /* Method returns the most Frequent Intger in a Array. */
        public int mostFrequentInteger(int[] array) {
            int mostFrequentInteger = int.MinValue;
            int mostFrequentCount = int.MinValue;
            /* Stores the Integer and its Frequency
                * Key = Integer
                * Value = Count
            */
            Dictionary<int, int> countOfNumbersInArray = new Dictionary<int, int>();

            // Adds each integer from the array => countOfNumbersInArray
            // Then increments its count 
            // If the integer is already in the Dictionary increment its current count by 1
            foreach(var integer in array) {
                if(countOfNumbersInArray.ContainsKey(integer)) {
                    countOfNumbersInArray[integer] += 1;
                } else {
                    countOfNumbersInArray.Add(integer, 1);
                }
            }

            // Loop through countOfNumbersInArray to find the most frequent integer
            foreach(var integer in countOfNumbersInArray) {
                if(integer.Value > mostFrequentCount) {
                    mostFrequentCount = integer.Value;
                    mostFrequentInteger = integer.Key;
                }
            }
            return mostFrequentInteger;
        }

        static void Main(string[] args) {
            int[] array = new int[] {1, 9, 7, 2, 4, 5, 6, 2, 9, 2, 5, 3, 1, 6, 8, 5, 6, 1, 4, 6};
            Program program = new Program();
            
            int returnResults= program.mostFrequentInteger(array);
            Console.WriteLine(returnResults);
        }
    }
}

/*
Given an array of integers, find the most frequent integer.
Write a method that takes an array of integers and returns an integer
*/



