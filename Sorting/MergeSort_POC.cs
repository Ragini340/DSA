namespace DataStructure.Sorting
{
/*
Merge Sort is a Divide and Conquer algorithm:
Divide the array into two halves.
Recursively sort each half.
Merge the sorted halves into one sorted array.
*/

/*
Time Complexity (TC):
Best Case    : O(n log n)
Average Case : O(n log n)
Worst Case   : O(n log n)
Reason:
- The array is divided into 2 halves recursively, creating log n levels.
- At each level, merging all elements takes O(n) time.
- Therefore, total time complexity = O(n) × O(log n) = O(n log n).

Space Complexity (SC): O(n)
Reason:
- Additional arrays (left[] and right[]) are created during the merge process.
- Total extra space required is proportional to the number of elements in the array.
*/
    public class MergeSort_POC
    {
        public static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return;
            }

            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int i = mid; i < arr.Length; i++)
            {
                right[i - mid] = arr[i];
            }

            MergeSort(left);
            MergeSort(right);
            Merge(arr, left, right);
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                arr[k++] = left[i++];
            }

            while (j < right.Length)
            {
                arr[k++] = right[j++];
            }
        }

        public static void Main(string[] args)
        {
            /* int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
             Console.WriteLine("Before Merge Sort:");
             foreach (int item in arr)
             {
                 Console.Write(item + " ");
             }

             Console.WriteLine("\nAfter Merge Sort:");
             MergeSort(arr);
             foreach (int item in arr)
             {
                 Console.Write(item + " ");
             }*/

            //Taking array elements from console
            Console.WriteLine("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Elements of array are:-");
            for (int i = 0; i < length; i++)
            {
                Console.Write("Array element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nArray elements after using Merge Sort:");
            MergeSort(arr);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }

        /*
         [38,27,43,3,9,82,10]
         |
    ----------------
    |              |
[38,27,43]   [3,9,82,10]
    |              |
 ------         -------
 |    |         |     |
[38] [27,43] [3,9] [82,10]
      |        |      |
    [27][43] [3][9] [82][10]

Merge Upward

[27][43] -> [27,43]
[38]+[27,43] -> [27,38,43]

[82][10] -> [10,82]
[3][9] -> [3,9]
[3,9]+[10,82] -> [3,9,10,82]

Final:
[27,38,43] + [3,9,10,82]
= [3,9,10,27,38,43,82]
         */

    }
}