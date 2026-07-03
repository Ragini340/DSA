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
/*
Call:
ClimbStairs(5)

Since n = 5 (> 2), execution continues.

----------------------------------------------------
Initial Values
----------------------------------------------------
first  = 1   // Ways to reach stair 1
second = 2   // Ways to reach stair 2

Loop:
for (int i = 3; i <= 5; i++)

----------------------------------------------------
Iteration 1 (i = 3)
----------------------------------------------------
Before:
first  = 1
second = 2

third = first + second
      = 1 + 2
      = 3

Update:
first  = second = 2
second = third  = 3

Current values:
first  = 2
second = 3

Meaning:
Ways to reach stair 3 = 3

----------------------------------------------------
Iteration 2 (i = 4)
----------------------------------------------------
Before:
first  = 2
second = 3

third = first + second
      = 2 + 3
      = 5

Update:
first  = second = 3
second = third  = 5

Current values:
first  = 3
second = 5

Meaning:
Ways to reach stair 4 = 5

----------------------------------------------------
Iteration 3 (i = 5)
----------------------------------------------------
Before:
first  = 3
second = 5

third = first + second
      = 3 + 5
      = 8

Update:
first  = second = 5
second = third  = 8

Current values:
first  = 5
second = 8

Meaning:
Ways to reach stair 5 = 8

----------------------------------------------------
Loop Ends
----------------------------------------------------

Return:
return second;

return 8;

Output:
8

+-----------+-------+--------+-------+--------------+---------------+
| Iteration | first | second | third | first (after)| second (after)|
+-----------+-------+--------+-------+--------------+---------------+
| Initial   |   1   |   2    |   -   |      1       |       2       |
| i = 3     |   1   |   2    |   3   |      2       |       3       |
| i = 4     |   2   |   3    |   5   |      3       |       5       |
| i = 5     |   3   |   5    |   8   |      5       |       8       |
+-----------+-------+--------+-------+--------------+---------------+

Sequence of ways:
Stair 1 → 1
Stair 2 → 2
Stair 3 → 3
Stair 4 → 5
Stair 5 → 8

Final Answer = 8
*/