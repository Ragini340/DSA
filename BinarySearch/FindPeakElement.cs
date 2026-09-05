using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinarySearch
{
    /*Given an array, find the index of any peak element. A peak element is an element that is greater than its neighboring elements.*/
    /*
    Time Complexity (TC):
    O(log n)

    Explanation:
    Binary Search is used to find a peak element.
    If numbers[middle] is smaller than numbers[middle + 1], a peak must
    exist on the right side.
    Otherwise, a peak exists on the left side or at the middle element.

    Therefore, the search space is approximately reduced by half in every
    iteration, giving a time complexity of O(log n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use a few variables (left, right, middle).
    No additional data structures are used.
*/
    public class FindPeakElement
    {
        public static int FindPeak(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int middle = left + (right - left) / 2;

                if (numbers[middle] < numbers[middle + 1])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            return left;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 1 };

            int result = FindPeak(numbers);

            Console.WriteLine(result);
        }
    }
}