using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinarySearch
{
    /*Given a sorted array containing duplicate elements, find the first occurrence of the target element.*/
    /*
    Time Complexity (TC):
    O(log n)

    Explanation:
    Binary Search cuts the search space approximately in half in every iteration.
    When the target is found, we store its index and continue searching
    in the left half to check if the target occurs earlier.

    Therefore, the time complexity is O(log n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use a few variables (left, right, middle, result).
    No additional data structures are used.
*/
    public class FirstOccurrenceOfElement
    {
        public static int FindFirst(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (numbers[middle] == target)
                {
                    result = middle;
                    right = middle - 1;
                }
                else if (numbers[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 2, 3, 4 };
            int target = 2;

            int result = FindFirst(numbers, target);

            Console.WriteLine(result);
        }
    }
}