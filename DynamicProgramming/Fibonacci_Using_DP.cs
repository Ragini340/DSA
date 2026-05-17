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