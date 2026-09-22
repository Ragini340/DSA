using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TwoPointers
{
    /*
     Question:
     Given an integer array sorted in non-decreasing order, return an array
     containing the squares of each number, also sorted in non-decreasing order.

     Example:
     Input:  [-4, -1, 0, 3, 10]

     Output:
     [0, 1, 9, 16, 100]
     */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use two pointers, one at the beginning and one at the end.
    The largest square will come from either the smallest negative
    number or the largest positive number.

    We compare both values and place the larger square at the end
    of the result array.

    Each element is processed once.

    Space Complexity (SC):
    O(n)

    Explanation:
    We use a result array of size n to store the sorted squares.
    */

    public class SquaresOfSortedArray
    {
        public static int[] GetSortedSquares(int[] numbers)
        {
            int[] result = new int[numbers.Length];

            int left = 0;
            int right = numbers.Length - 1;
            int position = numbers.Length - 1;

            while (left <= right)
            {
                int leftSquare = numbers[left] * numbers[left];
                int rightSquare = numbers[right] * numbers[right];

                if (leftSquare > rightSquare)
                {
                    result[position] = leftSquare;
                    left++;
                }
                else
                {
                    result[position] = rightSquare;
                    right--;
                }

                position--;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { -4, -1, 0, 3, 10 };

            int[] result = GetSortedSquares(numbers);

            Console.WriteLine("Sorted Squares: [" + string.Join(", ", result) + "]");
        }
    }
}