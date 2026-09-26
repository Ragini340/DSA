using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing
{
    /*
   Question:
   Given an integer array and an integer k, find the total number of
   continuous subarrays whose sum is equal to k.

   Example:
   Input:  [1, 1, 1]
   k = 2

   Output:
   2

   Explanation:
   The subarrays [1, 1] at indices 0-1 and 1-2 both have sum 2.
   */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use a prefix sum and a Dictionary.

    For each element, we calculate the current prefix sum.
    If (currentSum - k) already exists in the Dictionary, then the
    previous prefix sums can form subarrays whose sum is k.

    Each element is processed once and Dictionary operations take
    O(1) average time.

    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(n)

    Explanation:
    The Dictionary can store up to n different prefix sums.
    Therefore, the additional space complexity is O(n).
    */
    public class SubarraySumEqualsK
    {
        public static int CountSubarrays(int[] numbers, int k)
        {
            Dictionary<int, int> prefixSumFrequency = new Dictionary<int, int>();
            prefixSumFrequency[0] = 1;
            int currentSum = 0;
            int count = 0;

            foreach (int number in numbers)
            {
                currentSum += number;
                int requiredSum = currentSum - k;

                if (prefixSumFrequency.ContainsKey(requiredSum))
                {
                    count += prefixSumFrequency[requiredSum];
                }

                if (prefixSumFrequency.ContainsKey(currentSum))
                {
                    prefixSumFrequency[currentSum]++;
                }
                else
                {
                    prefixSumFrequency[currentSum] = 1;
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 1 };
            int k = 2;
            int result = CountSubarrays(numbers, k);
            Console.WriteLine("Number of Subarrays: " + result);
        }
    }
}