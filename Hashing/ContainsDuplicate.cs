using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hashing
{
    /*Given an integer array, determine whether any element appears more than once.
        Return true if any duplicate element exists; otherwise, return false.*/
    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We traverse the array only once.
    For each element, HashSet lookup and insertion take O(1) time on average.

    Therefore, for n elements, the overall time complexity is O(n).

    Space Complexity (SC):
    O(n)

    Explanation:
    In the worst case, all elements are unique and stored in the HashSet.
    Therefore, additional space can grow up to n elements.
    */
    public class ContainsDuplicate
    {
        public static bool Contains(int[] numbers)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int number in numbers)
            {
                if (seen.Contains(number))
                {
                    return true;
                }

                seen.Add(number);
            }

            return false;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 1 };

            bool result = Contains(numbers);

            Console.WriteLine(result);
        }
    }
}