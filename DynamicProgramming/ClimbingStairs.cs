using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DynamicProgramming
{
    /*
    Climbing Stairs
    Problem Statement
    You are climbing a staircase. It takes n steps to reach the top.

    Each time you can either climb:

    1 step
    2 steps

    Find the total number of distinct ways to reach the top.

    Example 1
    Input: n = 2

    Output: 2

    Explanation:
    1 + 1
    2
    Example 2
    Input: n = 3

    Output: 3

    Explanation:
    1 + 1 + 1
    1 + 2
    2 + 1
    */

    /*TC: O(n) because we calculate the answer iteratively in a single pass.
      SC: O(1) because the solution uses constant extra space instead of storing all previous results in an array.
    */
    public class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;

            int first = 1;
            int second = 2;

            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }

            return second;
        }

        public static void Main()
        {
            int result = ClimbStairs(5);

            Console.WriteLine(result);
        }
    }
}