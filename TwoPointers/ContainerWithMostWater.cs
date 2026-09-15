using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TwoPointers
{
    /*
    Question:
    Given an integer array representing vertical lines where the value at each
    index represents the height of the line, find two lines that together with
    the x-axis form a container containing the maximum amount of water.

    Example:
    Input:  [1,8,6,2,5,4,8,3,7]
    Output: 49
    */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use two pointers, one at the beginning and one at the end of the array.
    At each step, calculate the area and move the pointer pointing to the
    shorter line. Each pointer moves at most n times.

    Space Complexity (SC):
    O(1)

    Explanation:
    Only two pointers and a few variables are used, so constant extra space
    is required.
    */

    public class ContainerWithMostWater
    {
        public static int FindMaximumWater(int[] heights)
        {
            int left = 0;
            int right = heights.Length - 1;
            int maxWater = 0;

            while (left < right)
            {
                int width = right - left;
                int height = Math.Min(heights[left], heights[right]);

                int currentWater = width * height;

                maxWater = Math.Max(maxWater, currentWater);

                if (heights[left] < heights[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxWater;
        }

        public static void Main(string[] args)
        {
            int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            int result = FindMaximumWater(heights);

            Console.WriteLine("Maximum Water: " + result);
        }
    }
}