using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.DynamicProgramming
{
    /*Fibonacci Using Dynamic Programming*/

    /*
     * Time Complexity (TC): O(n)
     * -----------------------
     * The loop runs from 2 to n, performing a constant amount of work in each iteration.
     * Therefore, the total time complexity is O(n).
     *
     * Space Complexity (SC): O(1)
     * ---------------------------
     * Only three integer variables (a, b, c) are used regardless of the input size.
     * No additional data structures are created.
     * Therefore, the space complexity is O(1).
     */
    public class Fibonacci_Using_DP
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1;

            for (int i = 2; i <= n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return b;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(10));
        }
    }
}
/*
 Fibonacci(10)

n = 10

Since n > 1:
a = 0
b = 1

i = 2
c = 0 + 1 = 1
a = 1
b = 1

i = 3
c = 1 + 1 = 2
a = 1
b = 2

i = 4
c = 1 + 2 = 3
a = 2
b = 3

i = 5
c = 2 + 3 = 5
a = 3
b = 5

i = 6
c = 3 + 5 = 8
a = 5
b = 8

i = 7
c = 5 + 8 = 13
a = 8
b = 13

i = 8
c = 8 + 13 = 21
a = 13
b = 21

i = 9
c = 13 + 21 = 34
a = 21
b = 34

i = 10
c = 21 + 34 = 55
a = 34
b = 55

Return b = 55
 */