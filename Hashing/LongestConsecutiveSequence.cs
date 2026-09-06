using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing
{
    /*Given an unsorted array of integers, find the length of the longest sequence of consecutive integers.*/
    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We store all elements in a HashSet for O(1) average-time lookup.
    For each number, we start counting only if the previous number does not exist.
    This ensures that every consecutive sequence is processed only once.

    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(n)

    Explanation:
    We use a HashSet to store the elements of the array.
    In the worst case, the HashSet contains n elements.
*/
    public class LongestConsecutiveSequence
    {
        public static int FindLongest(int[] numbers)
        {
            HashSet<int> numbersSet = new HashSet<int>(numbers);

            int longest = 0;

            foreach (int number in numbersSet)
            {
                if (!numbersSet.Contains(number - 1))
                {
                    int current = number;
                    int length = 1;

                    while (numbersSet.Contains(current + 1))
                    {
                        current++;
                        length++;
                    }

                    longest = Math.Max(longest, length);
                }
            }

            return longest;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 100, 4, 200, 1, 3, 2 };

            int result = FindLongest(numbers);

            Console.WriteLine(result);
        }
    }
}