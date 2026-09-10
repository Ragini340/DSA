using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.SlidingWindow
{
    /*Given an integer array and an integer k, find the maximum sum of any contiguous subarray of size k.*/
    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use the Sliding Window technique.
    First, we calculate the sum of the first k elements.
    Then, we slide the window one position at a time by removing
    the element leaving the window and adding the new element.

    Each element is added to and removed from the window only once.
    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use a few variables (windowSum, maxSum, left).
    No additional data structures are used.
*/
    public class MaximumSumSubarrayOfSizeK
    {
        public static int FindMaximumSum(int[] numbers, int k)
        {
            if (numbers == null || numbers.Length == 0 ||
                k <= 0 || k > numbers.Length)
            {
                return 0;
            }

            int windowSum = 0;

            for (int i = 0; i < k; i++)
            {
                windowSum += numbers[i];
            }

            int maxSum = windowSum;

            for (int right = k; right < numbers.Length; right++)
            {
                windowSum += numbers[right];
                windowSum -= numbers[right - k];

                maxSum = Math.Max(maxSum, windowSum);
            }

            return maxSum;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 5, 1, 3, 2 };
            int k = 3;

            int result = FindMaximumSum(numbers, k);

            Console.WriteLine(result);
        }
    }
}