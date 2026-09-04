using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinarySearch
{
    /*Given a sorted array that has been rotated at an unknown position, find the index of the target element. Return -1 if it does 
    not exist.*/
    /*
    Time Complexity (TC):
    O(log n)

    Explanation:
    In every iteration, Binary Search determines which half of the rotated
    array is sorted and eliminates the half that cannot contain the target.

    Therefore, the search space is approximately reduced by half in every
    iteration, giving a time complexity of O(log n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use a few variables (left, right, middle).
    No additional data structures are used.
*/
    public class SearchInRotatedSortedArray
    {
        public static int Search(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (numbers[middle] == target)
                {
                    return middle;
                }

                // Left half is sorted
                if (numbers[left] <= numbers[middle])
                {
                    if (numbers[left] <= target && target < numbers[middle])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
                // Right half is sorted
                else
                {
                    if (numbers[middle] < target && target <= numbers[right])
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle - 1;
                    }
                }
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;

            int result = Search(numbers, target);

            Console.WriteLine(result);
        }
    }
}