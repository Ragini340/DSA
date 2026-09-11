using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.SlidingWindow
{
    /*Given an array of positive integers and a target value, find the minimum length
      of a contiguous subarray whose sum is greater than or equal to the target.
      Return 0 if no such subarray exists.*/
    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use the Sliding Window technique.
    The right pointer expands the window by adding elements to the current sum.
    Whenever the current sum becomes greater than or equal to the target,
    we try to shrink the window from the left while maintaining the required sum.

    Each element is added to the window once and removed from the window at most once.
    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use a few variables (left, right, sum, and minLength).
    No additional data structures are used.
*/
    public class MinimumSizeSubarraySum
    {
        public static int FindMinimumLength(int[] numbers, int target)
        {
            int left = 0;
            int sum = 0;
            int minLength = int.MaxValue;

            for (int right = 0; right < numbers.Length; right++)
            {
                sum += numbers[right];

                while (sum >= target)
                {
                    int currentLength = right - left + 1;

                    minLength = Math.Min(minLength, currentLength);

                    sum -= numbers[left];
                    left++;
                }
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 1, 2, 4, 3 };
            int target = 7;

            int result = FindMinimumLength(numbers, target);

            Console.WriteLine(result);
        }
    }
}