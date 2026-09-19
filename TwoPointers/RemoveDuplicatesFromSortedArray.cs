using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.TwoPointers
{
    /*
     Question:
     Given a sorted integer array, remove the duplicates in-place such that each unique element appears only once.

     Return the number of unique elements.

     Example:
     Input:  [1, 1, 2, 2, 3, 4, 4]

     Output:
     Number of unique elements = 4
     Array = [1, 2, 3, 4]
     */

    /*
    Time Complexity (TC):
    O(n)

    Explanation:
    We use two pointers. The first pointer keeps track of the position
    where the next unique element should be placed, while the second
    pointer scans the array.

    Each element is visited only once.

    Space Complexity (SC):
    O(1)

    Explanation:
    The array is modified in-place and only a few variables are used.
    No additional data structure is required.
    */

    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            int uniqueIndex = 1;

            for (int currentIndex = 1;
                 currentIndex < numbers.Length;
                 currentIndex++)
            {
                if (numbers[currentIndex] != numbers[currentIndex - 1])
                {
                    numbers[uniqueIndex] = numbers[currentIndex];

                    uniqueIndex++;
                }
            }

            return uniqueIndex;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 2, 3, 4, 4 };

            int uniqueCount = RemoveDuplicates(numbers);

            Console.WriteLine("Number of Unique Elements: " + uniqueCount);

            Console.WriteLine("Array: [" + string.Join(", ", numbers.Take(uniqueCount)) + "]");
        }
    }
}