using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class CountSortPOC
    {
        private static void sortbyFreq(int[] arr)
        {
            int[] freq = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                int index = arr[i];
                freq[index]++;
            }
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= freq[i]; j++)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        /*static void Main(string[] args)
        {
            int[] arr = { 3, 1, 4, 4, 2, 4, 2, 3, 1, 2 };
            sortbyFreq(arr);
            Console.WriteLine();
        }*/

    }
}