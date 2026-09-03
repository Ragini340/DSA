using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinarySearch
{
    public class BinarySearch
    {
        public static int Search(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (numbers[middle] == target)
                {
                    return middle;
                }

                if (numbers[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            int target = 7;

            int result = Search(numbers, target);

            Console.WriteLine(result);
        }
    }
}