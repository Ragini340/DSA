using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    /*
    Question:
    Given an integer array, return an array where each element is the
    product of all elements in the original array except the element
    at the current index.

    Do not use division.

    Example:
    Input:  [1, 2, 3, 4]
    Output: [24, 12, 8, 6]
    */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We make one pass from left to right to store the product of all
    elements before each index, and one pass from right to left to
    multiply the product of all elements after each index.

    Space Complexity (SC):
    O(1) extra space

    Explanation:
    Apart from the output array, only a few variables are used.
    */
    public class ProductOfArrayExceptSelf
    {
        public static int[] CalculateProduct(int[] numbers)
        {
            int[] result = new int[numbers.Length];

            int prefixProduct = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = prefixProduct;
                prefixProduct *= numbers[i];
            }

            int suffixProduct = 1;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                result[i] *= suffixProduct;
                suffixProduct *= numbers[i];
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };

            int[] result = CalculateProduct(numbers);

            Console.WriteLine("Product Array: [" + string.Join(", ", result) + "]");
        }
    }
}