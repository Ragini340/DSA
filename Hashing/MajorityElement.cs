using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing
{
    /*
    Question:
    Given an integer array, find the element that appears more than n / 2 times.
    You may assume that the majority element always exists.

    Example:
    Input:  [2, 2, 1, 1, 1, 2, 2]

    Output:
    2
    */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use the Boyer-Moore Voting Algorithm.

    We maintain a candidate and a count.
    If the count becomes zero, the current element becomes the new candidate.

    If the current element is equal to the candidate, we increase the count.
    Otherwise, we decrease the count.

    Since the majority element appears more than n / 2 times, it will remain as the final candidate.

    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use two variables: candidate and count.
    No additional data structure is required.
    */
    public class MajorityElement
    {
        public static int FindMajority(int[] numbers)
        {
            int candidate = 0;
            int count = 0;

            foreach (int number in numbers)
            {
                if (count == 0)
                {
                    candidate = number;
                }

                if (number == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return candidate;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 2, 2, 1, 1, 1, 2, 2 };
            int result = FindMajority(numbers);
            Console.WriteLine("Majority Element: " + result);
        }
    }
}