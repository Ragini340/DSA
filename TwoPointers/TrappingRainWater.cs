using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TwoPointers
{
    /*
     Question:
     Given n non-negative integers representing an elevation map where
     the width of each bar is 1, compute how much water it can trap
     after raining.

     Example:
     Input:  [0,1,0,2,1,0,1,3,2,1,2,1]
     Output: 6
     */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use two pointers, one at the beginning and one at the end.
    We maintain the maximum height seen from the left and right.

    At each step, the pointer with the smaller height is moved because
    the amount of trapped water depends on the smaller boundary.

    Each element is processed only once.

    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use a few variables:
    left, right, leftMax, rightMax, and water.

    No additional data structures are used.
    */

    public class TrappingRainWater
    {
        public static int CalculateTrappedWater(int[] heights)
        {
            int left = 0;
            int right = heights.Length - 1;

            int leftMax = 0;
            int rightMax = 0;

            int water = 0;

            while (left < right)
            {
                if (heights[left] < heights[right])
                {
                    if (heights[left] >= leftMax)
                    {
                        leftMax = heights[left];
                    }
                    else
                    {
                        water += leftMax - heights[left];
                    }

                    left++;
                }
                else
                {
                    if (heights[right] >= rightMax)
                    {
                        rightMax = heights[right];
                    }
                    else
                    {
                        water += rightMax - heights[right];
                    }

                    right--;
                }
            }

            return water;
        }

        public static void Main(string[] args)
        {
            int[] heights =
            {
                0, 1, 0, 2, 1, 0,
                1, 3, 2, 1, 2, 1
            };

            int result = CalculateTrappedWater(heights);

            Console.WriteLine("Trapped Water: " + result);
        }
    }
}