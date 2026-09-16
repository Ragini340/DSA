using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TwoPointers
{
    /*
    Question:
    Given an integer array, find all unique triplets [a, b, c] such that:

    a + b + c = 0

    Example:
    Input:  [-1, 0, 1, 2, -1, -4]

    Output:
    [-1, -1, 2]
    [-1, 0, 1]
    */

    /*
    Time Complexity (TC):
    O(n^2)

    Explanation:
    First, sort the array in O(n log n).
    Then, for each element, use two pointers to find the remaining
    two elements. The two-pointer search takes O(n) for each element,
    resulting in O(n^2) overall.

    Space Complexity (SC):
    O(1)

    Explanation:
    Apart from the output list, only a constant number of variables
    and pointers are used.
    */

    public class ThreeSum
    {
        public static IList<IList<int>> FindThreeSum(int[] numbers)
        {
            Array.Sort(numbers);

            List<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                // Skip duplicate first elements
                if (i > 0 && numbers[i] == numbers[i - 1])
                {
                    continue;
                }

                int left = i + 1;
                int right = numbers.Length - 1;

                while (left < right)
                {
                    int sum = numbers[i] + numbers[left] + numbers[right];

                    if (sum == 0)
                    {
                        result.Add(new List<int>
                        {
                            numbers[i],
                            numbers[left],
                            numbers[right]
                        });

                        // Skip duplicate values
                        while (left < right &&
                               numbers[left] == numbers[left + 1])
                        {
                            left++;
                        }

                        while (left < right &&
                               numbers[right] == numbers[right - 1])
                        {
                            right--;
                        }

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { -1, 0, 1, 2, -1, -4 };

            IList<IList<int>> result = FindThreeSum(numbers);

            foreach (IList<int> triplet in result)
            {
                Console.WriteLine(
                    "[" + string.Join(", ", triplet) + "]"
                );
            }
        }
    }
}