using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    /*
     * Problem:
     * Given an integer array, find the contiguous subarray which has the largest product and return the product.
     
     * Example:
     * Input:  [2, 3, -2, 4]
     * Output: 6
     *
     * Explanation:
     * Subarray [2, 3] has the maximum product = 6.
     *
     * Time Complexity: O(n)
     * Space Complexity: O(1)
     */

    public class MaximumProductSubarray
    {
        public static int MaxProduct(int[] nums)
        {
            int currentMax = nums[0];
            int currentMin = nums[0];
            int result = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int value = nums[i];

                if (value < 0)
                {
                    int temp = currentMax;
                    currentMax = currentMin;
                    currentMin = temp;
                }

                currentMax = Math.Max(value, currentMax * value);
                currentMin = Math.Min(value, currentMin * value);

                result = Math.Max(result, currentMax);
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 2, 3, -2, 4 };

            int result = MaxProduct(nums);

            Console.WriteLine(result);
        }
    }
}