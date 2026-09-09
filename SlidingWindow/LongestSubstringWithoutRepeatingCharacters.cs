using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.SlidingWindow
{
    /*Given a string, find the length of the longest substring without repeating characters.*/
    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use the Sliding Window technique with a Dictionary to store the
    latest index of each character.

    The right pointer moves through the string once.
    When a duplicate character is found inside the current window,
    we move the left pointer to the position after its previous occurrence.

    Each character is processed at most a constant number of times.
    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(n)

    Explanation:
    We use a Dictionary to store the latest index of each character.
    In the worst case, all characters in the string are unique,
    so the Dictionary can contain n characters.
*/
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static int FindLongest(string input)
        {
            Dictionary<char, int> lastSeen = new Dictionary<char, int>();

            int left = 0;
            int longest = 0;

            for (int right = 0; right < input.Length; right++)
            {
                char currentCharacter = input[right];

                if (lastSeen.ContainsKey(currentCharacter) &&
                    lastSeen[currentCharacter] >= left)
                {
                    left = lastSeen[currentCharacter] + 1;
                }

                lastSeen[currentCharacter] = right;

                int currentLength = right - left + 1;

                longest = Math.Max(longest, currentLength);
            }

            return longest;
        }

        public static void Main(string[] args)
        {
            string input = "abcabcbb";

            int result = FindLongest(input);

            Console.WriteLine(result);
        }
    }
}