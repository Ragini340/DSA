using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Strings
{
    /*
    * Problem:
    * Given a string, find the length of the longest substring without repeating characters.
    *
    * Example:
    * Input:  "abcabcbb"
    * Output: 3
    *
    * Explanation:
    * The longest substring without repeating characters is "abc".
    *
    * Time Complexity: O(n)
    * Space Complexity: O(n)
    */

    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> characters = new HashSet<char>();

            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (characters.Contains(s[right]))
                {
                    characters.Remove(s[left]);
                    left++;
                }

                characters.Add(s[right]);

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }

        public static void Main(string[] args)
        {
            string s = "abcabcbb";

            int result = LengthOfLongestSubstring(s);

            Console.WriteLine(result);
        }
    }
}