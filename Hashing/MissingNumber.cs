using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing
{
    /*
    Question:
    Given an array containing n distinct numbers taken from the range 0 to n, find the one number that is missing from the array.

    Example:
    Input:  [3, 0, 1]

    Output:
    2
    */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use the XOR operation.

    XOR has two important properties:
    1. x ^ x = 0
    2. x ^ 0 = x

    By XORing all numbers from 0 to n with all elements in the array, every number that exists in both sets cancels out.
    The only remaining number is the missing number.

    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use a few variables and do not create any additional data structure.
    */
    public class MissingNumber
    {
        public static int FindMissingNumber(int[] numbers)
        {
            int missing = numbers.Length;

            for (int i = 0; i < numbers.Length; i++)
            {
                missing ^= i;
                missing ^= numbers[i];
            }

            return missing;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 3, 0, 1 };
            int result = FindMissingNumber(numbers);
            Console.WriteLine("Missing Number: " + result);
        }
    }
}