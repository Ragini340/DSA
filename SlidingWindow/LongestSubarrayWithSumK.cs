using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.SlidingWindow
{
    /*Given an array of positive integers and an integer k, find the length
      of the longest contiguous subarray whose sum is equal to k.*/
    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use the Sliding Window technique.
    The right pointer expands the window by adding elements to the current sum.

    Whenever the current sum becomes greater than k, we shrink the window
    from the left until the sum becomes less than or equal to k.

    Whenever the current sum becomes equal to k, we calculate the length
    of the current window and update the maximum length.

    Each element is added and removed from the window at most once.
    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use a few variables (left, right, sum, and longest).
    No additional data structures are used.
*/
    public class LongestSubarrayWithSumK
    {
        public static int FindLongest(int[] numbers, int k)
        {
            int left = 0;
            int sum = 0;
            int longest = 0;

            for (int right = 0; right < numbers.Length; right++)
            {
                sum += numbers[right];

                while (sum > k && left <= right)
                {
                    sum -= numbers[left];
                    left++;
                }

                if (sum == k)
                {
                    int currentLength = right - left + 1;

                    longest = Math.Max(longest, currentLength);
                }
            }

            return longest;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 1, 1, 1, 3, 2 };
            int k = 5;

            int result = FindLongest(numbers, k);

            Console.WriteLine(result);
        }
    }
}