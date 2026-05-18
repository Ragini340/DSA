using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Array
{
/*Find two numbers whose sum equals the target.*/

/*Time Complexity (TC): O(n)

Reason:
- We traverse the array only once.
- Dictionary lookup (ContainsKey) and insertion are O(1) on average.

Space Complexity (SC): O(n)

Reason:
- In the worst case, all n elements are stored in the Dictionary.*/

    public class TwoSum
    {
        public static int[] FindTwoSum(int[] nums, int target)
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

            return new int[] { -1, -1 };
        }

        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = FindTwoSum(nums, target);

            Console.WriteLine("Indices: " + result[0] + ", " + result[1]);
        }
    }
}