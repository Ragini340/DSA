using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.SlidingWindow
{
    /*Given a string containing uppercase English letters and an integer k,
         find the length of the longest substring that can be made to contain
         the same character by replacing at most k characters.*/
    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use the Sliding Window technique.
    The right pointer expands the window and keeps track of the frequency
    of each character.

    We also maintain the frequency of the most frequent character in the
    current window.

    If the number of characters that need to be replaced is greater than k,
    we move the left pointer to shrink the window.

    Each character is processed at most a constant number of times.
    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We use an integer array of size 26 to store the frequency of uppercase
    English characters.

    Since the array size is fixed at 26, the space complexity is O(1).
*/
    public class LongestRepeatingCharacterReplacement
    {
        public static int FindLongest(string input, int k)
        {
            int[] frequency = new int[26];

            int left = 0;
            int maxFrequency = 0;
            int longest = 0;

            for (int right = 0; right < input.Length; right++)
            {
                int index = input[right] - 'A';

                frequency[index]++;

                maxFrequency = Math.Max(maxFrequency, frequency[index]);

                int windowLength = right - left + 1;

                int charactersToReplace = windowLength - maxFrequency;

                if (charactersToReplace > k)
                {
                    frequency[input[left] - 'A']--;
                    left++;
                }

                windowLength = right - left + 1;

                longest = Math.Max(longest, windowLength);
            }

            return longest;
        }

        public static void Main(string[] args)
        {
            string input = "AABABBA";
            int k = 1;

            int result = FindLongest(input, k);

            Console.WriteLine(result);
        }
    }
}