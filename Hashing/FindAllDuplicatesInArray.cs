using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing
{
    /*
    Question:
    Given an integer array containing n integers where each integer is
    between 1 and n, find all elements that appear twice.

    Example:
    Input:  [4, 3, 2, 7, 8, 2, 3, 1]

    Output:
    [2, 3]
    */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use a HashSet to keep track of elements that have already been seen.

    For every element:
    - If it is not present in the HashSet, add it.
    - If it is already present, add it to the result because it is a duplicate.

    Each element is processed once and HashSet operations take O(1)
    average time.

    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(n)

    Explanation:
    In the worst case, the HashSet can contain n elements.
    The result can also contain duplicate elements.

    Therefore, the additional space complexity is O(n).
    */
    public class FindAllDuplicatesInArray
    {
        public static IList<int> FindDuplicates(int[] numbers)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (int number in numbers)
            {
                if (seen.Contains(number))
                {
                    duplicates.Add(number);
                }
                else
                {
                    seen.Add(number);
                }
            }

            return duplicates;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> result = FindDuplicates(numbers);
            Console.WriteLine("Duplicates: [" + string.Join(", ", result) + "]");
        }
    }
}