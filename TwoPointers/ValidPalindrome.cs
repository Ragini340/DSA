using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TwoPointers
{
    /*
    Given a string, determine whether it is a palindrome after converting
    all uppercase letters to lowercase and removing all non-alphanumeric
    characters.

    Example:
    Input:  "A man, a plan, a canal: Panama"
    Output: true

    Input:  "race a car"
    Output: false
    */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use two pointers, one from the beginning and one from the end.
    Each character is examined at most once.

    Space Complexity (SC):
    O(1)

    Explanation:
    No additional data structure is used. Only two pointers and variables
    are required.
    */

    public class ValidPalindrome
    {
        public static bool IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                while (left < right &&
                       !char.IsLetterOrDigit(input[left]))
                {
                    left++;
                }

                while (left < right &&
                       !char.IsLetterOrDigit(input[right]))
                {
                    right--;
                }

                if (char.ToLower(input[left]) != char.ToLower(input[right]))
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            string input = "A man, a plan, a canal: Panama";

            bool result = IsPalindrome(input);

            Console.WriteLine("Is Palindrome: " + result);
        }
    }
}