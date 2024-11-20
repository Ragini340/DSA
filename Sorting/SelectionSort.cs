using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sorting
{
    /*Time Complexity = O(n) * O(n) = O(n2)
    Space Complexity = O(1)
    Output:
    -4
    -1
     1
     2
     3
     5
    */
    public class SelectionSort
    {
        public static void selectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minElementIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minElementIndex] > arr[j])
                    {
                        minElementIndex = j;
                    }
                }

                //Swap arr[i], arr[minElementIndix]
                int temp = arr[i];
                arr[i] = arr[minElementIndex];
                arr[minElementIndex] = temp;
            }
        }

        //Print sorted array
        public static void printSortedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
