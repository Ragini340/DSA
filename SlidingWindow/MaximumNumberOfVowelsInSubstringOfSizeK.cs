using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.SlidingWindow
{
    /*Given a string and an integer k, find the maximum number of vowels present in any substring of size k.*/
    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use the Sliding Window technique.
    First, we count the number of vowels in the first k characters.
    Then, we slide the window one character at a time.

    When the window moves:
    - If the new character is a vowel, increase the vowel count.
    - If the character leaving the window is a vowel, decrease the vowel count.

    Each character is processed only once.
    Therefore, the overall time complexity is O(n).

    Space Complexity (SC):
    O(1)

    Explanation:
    We only use a few variables to maintain the current and maximum
    vowel counts. No additional data structures are used.
*/
    public class MaximumNumberOfVowelsInSubstringOfSizeK
    {
        public static int FindMaximumVowels(string input, int k)
        {
            if (string.IsNullOrEmpty(input) ||
                k <= 0 ||
                k > input.Length)
            {
                return 0;
            }

            int vowelCount = 0;

            for (int i = 0; i < k; i++)
            {
                if (IsVowel(input[i]))
                {
                    vowelCount++;
                }
            }

            int maxVowels = vowelCount;

            for (int right = k; right < input.Length; right++)
            {
                if (IsVowel(input[right]))
                {
                    vowelCount++;
                }

                if (IsVowel(input[right - k]))
                {
                    vowelCount--;
                }

                maxVowels = Math.Max(maxVowels, vowelCount);
            }

            return maxVowels;
        }

        private static bool IsVowel(char character)
        {
            return character == 'a' ||
                   character == 'e' ||
                   character == 'i' ||
                   character == 'o' ||
                   character == 'u';
        }

        public static void Main(string[] args)
        {
            string input = "abciiidef";
            int k = 3;

            int result = FindMaximumVowels(input, k);

            Console.WriteLine(result);
        }
    }
}