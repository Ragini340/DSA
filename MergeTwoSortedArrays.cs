using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class MergeTwoSortedArrays
    {
        public static void mergeTwoSortedArray(int[] arr1, int[] arr2, int[] arr3)
        {
            int i = 0, j = 0, k = 0;
            int n1 = arr1.Length;
            int n2 = arr2.Length;

            while (i < n1 && j < n2)
            {
                // Pick smaller of the two current elements and move ahead in the array of the picked element
                if (arr1[i] < arr2[j])
                {
                    arr3[k++] = arr1[i++];
                }
                else
                {
                    arr3[k++] = arr2[j++];
                }
            }

            // if there are remaining elements of the first array, move them
            while (i < n1)
            {
                arr3[k++] = arr1[i++];
            }

            // Else if there are remaining elements of the second array, move them
            while (j < n2)
            {
                arr3[k++] = arr2[j++];
            }

        }

    }
}
