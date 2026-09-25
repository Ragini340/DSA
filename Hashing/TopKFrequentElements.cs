using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing
{
    /*
    Question:
    Given an integer array and an integer k, return the k most frequent
    elements in the array.

    Example:
    Input:  [1, 1, 1, 2, 2, 3]
    k = 2

    Output:
    [1, 2]
    */

    /*
    Time Complexity (TC):
    O(n log n)

    Explanation:
    First, we count the frequency of each element using a dictionary.
    Then, we sort the distinct elements by their frequency.
    If there are n elements, sorting takes O(n log n).

    Space Complexity (SC):
    O(n)

    Explanation:
    The dictionary stores the frequency of each distinct element,
    and the result contains k elements.
    */

    public class TopKFrequentElements
    {
        public static int[] FindTopKFrequent(int[] numbers, int k)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            }

            int[] result = frequency.OrderByDescending(item => item.Value).Take(k).Select(item => item.Key).ToArray();

            return result;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            int[] result = FindTopKFrequent(numbers, k);
            Console.WriteLine("Top " + k + " Frequent Elements: [" + string.Join(", ", result) + "]");
        }
    }
}