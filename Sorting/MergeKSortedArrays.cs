namespace DataStructure.Sorting
{
    /*
       Merge K Sorted Arrays
       You have been given ‘K’ different arrays/lists, which are sorted individually (in ascending order). 
       You need to merge all the given arrays/list such that the output array/list should be sorted in ascending order.
    */
    public class MergeKSortedArrays
    {
        public static int[] MergeSortedArrays(int[][] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total = total + arr[i].Length;
            }
            int[] result = new int[total];

            if (arr.Length <= 1)
            {
                return arr[0];
            }
            else if (arr.Length == 2)
            {
                return MergeTwoSortedArray(arr[0], arr[1]);
            }
            else
            {
                int i = 2;
                result = MergeTwoSortedArray(arr[0], arr[1]);
                while (i < arr.Length)
                {
                    result = MergeTwoSortedArray(arr[i], result);
                    i++;
                }
            }

            return result;
        }

        private static int[] MergeTwoSortedArray(int[] arr1, int[] arr2)
        {
            int i = 0, j = 0, k = 0;
            int[] c = new int[arr1.Length + arr2.Length];

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    c[k] = arr1[i];
                    k++;
                    i++;
                }
                else
                {
                    c[k] = arr2[j];
                    k++;
                    j++;
                }
            }

            while (i < arr1.Length)
            {
                c[k++] = arr1[i];
                i++;
            }

            while (j < arr2.Length)
            {
                c[k++] = arr2[j];
                j++;
            }

            return c;
        }

        public static void Main(String[] args)
        {
            int[][] arr =
            {  new int[]{ 2, 6, 12, 34 },
              new int[]{ 1, 9, 20, 1000 },
              new int[]{ 23, 34, 90, 2000 },
              new int[]{ 50, 60, 80, 500 },
              new int[]{ 10, 20, 30, 40 }
            };

            int[] result = MergeSortedArrays(arr);

            Console.Write("Merged K sorted arrays is: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

    }
}