using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TwoPointers
{
    /*
   Question:
   Given an integer array, move all zeroes to the end of the array
   while maintaining the relative order of the non-zero elements.

   The operation must be performed in-place.

   Example:
   Input:  [0, 1, 0, 3, 12]

   Output:
   [1, 3, 12, 0, 0]
   */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use two pointers. The first pointer keeps track of the position
    where the next non-zero element should be placed. The second pointer
    scans the entire array.

    Each element is processed only once.

    Space Complexity (SC):
    O(1)

    Explanation:
    The array is modified in-place and only a few variables are used.
    No additional array or data structure is required.
    */
    public class MoveZeroes
    {
        public static void Move(int[] numbers)
        {
            int nonZeroIndex = 0;

            for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
            {
                if (numbers[currentIndex] != 0)
                {
                    int temp = numbers[nonZeroIndex];
                    numbers[nonZeroIndex] = numbers[currentIndex];
                    numbers[currentIndex] = temp;
                    nonZeroIndex++;
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 0, 3, 12 };
            Move(numbers);
            Console.WriteLine("Array After Moving Zeroes: [" + string.Join(", ", numbers) + "]");
        }
    }
}