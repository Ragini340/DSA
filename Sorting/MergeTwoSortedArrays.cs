namespace DataStructure.Sorting
{
    public class MergeTwoSortedArrays
    {
        /* Time Complexity: O(N + M)
         * Space Complexity: O(1) beacause it took extra space for storing result in arr3 not for sorting the array.
         */
        public static void MergeTwoSortedArray(int[] arr1, int[] arr2, int[] arr3)
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

        public static void Main(string[] args)
        {
            int[] arr1 = { 2, 5, 7, 12, 20, 24, 29 };
            int[] arr2 = { 6, 9, 12, 14, 15, 19 };
            int[] arr3 = new int[arr1.Length + arr2.Length];

            MergeTwoSortedArrays.MergeTwoSortedArray(arr1, arr2, arr3);
            Console.WriteLine("Merged two sorted arrays's elements: ");
            foreach (int sortedValue in arr3)
            {
                Console.Write(sortedValue + " ");
            }
        }

    }
}