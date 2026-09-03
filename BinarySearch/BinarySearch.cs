using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinarySearch
{
    /*Given a sorted array and a target value, find the index of the target using Binary Search. Return -1 if it does not exist.*/
    /*
    Time Complexity (TC):
    O(log n)

    Explanation:
    In every iteration, Binary Search cuts the search space approximately in half.
    Therefore, for n elements, the maximum number of iterations is log2(n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use a few variables (left, right, middle, result).
    No additional data structures are used.
*/
    public class BinarySearch
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

                if (numbers[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            int target = 7;

            int result = Search(numbers, target);

            Console.WriteLine(result);
        }
    }
}