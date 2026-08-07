using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Coding_Questions
{
    /*
    Question:
    Given an integer array nums and an integer target, return the indices of
    the two numbers such that they add up to target.

    You may assume that each input has exactly one solution, and you may not
    use the same element twice.

    You can return the answer in any order.

    Example:
    Input:
    nums = [2,7,11,15]
    target = 9

    Output:
    [0,1]

    Explanation:
    nums[0] + nums[1] = 2 + 7 = 9

    Approach:
    1. Create a Dictionary to store number and its index.
    2. Traverse the array once.
    3. Find the complement = target - current number.
    4. If complement exists in Dictionary, return both indices.
    5. Otherwise, store current number and its index.

   Time Complexity (TC): O(n)
   - The array is traversed only once using the for loop.
   - Dictionary operations like ContainsKey() and insertion take O(1) time on average.
   - Therefore, the overall time complexity is O(n).

   Space Complexity (SC): O(n)
   - A Dictionary is used to store each number and its index.
   - In the worst case, the dictionary can store all elements of the array.
   - Therefore, the extra space complexity is O(n).
    */
    public class TwoSum
    {
        public int[] TwoSums(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                map[nums[i]] = i;
            }

            return new int[] { };
        }

        public static void Main(string[] args)
        {
            TwoSum twoSum = new TwoSum();

            // Input
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // Call method
            int[] result = twoSum.TwoSums(nums, target);

            // Output
            Console.WriteLine("Indices: " + string.Join(", ", result));

            Console.ReadLine();
        }
    }
}