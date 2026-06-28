namespace DataStructure.Sorting
{
    /*
     Merge 2-dimensional sorted arrays into one 1-Dimesional output array and sort the output array using any sorting algorithm.
     */

    /*Time Complexity(TC):
    - Merging 2D array into 1D array: O(N)
    - Insertion Sort:
      Best Case    : O(N)
      Average Case : O(N²)
      Worst Case   : O(N²)

    Overall Time Complexity: O(N²)

    Space Complexity(SC):
    - Output array: O(N)
    - Extra space used by Insertion Sort: O(1)

    Overall Space Complexity: O(N)

    Where N is the total number of elements in the 2D array.
    */

    public class SortingOfTwoDArray
    {
        public static void SortTwoDArray(int[][] arr, int[] outputArr)
        {
            int k = 0;
            Console.WriteLine("\nOutput array length is: " + outputArr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    outputArr[k++] = arr[i][j];
                }
            }

            //Printing output array
            Console.WriteLine("\nOutput array is: ");
            for (int l = 0; l < outputArr.Length; l++)
            {
                Console.Write(outputArr[l] + " ");
            }
            Console.WriteLine();

            InsertionSort(outputArr);
        }

        //Sorting using Insertion sort 
        public static void InsertionSort(int[] outputArr)
        {
            for (int i = 1; i < outputArr.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (outputArr[j] > outputArr[j + 1])
                    {
                        int temp = outputArr[j];
                        outputArr[j] = outputArr[j + 1];
                        outputArr[j + 1] = temp;
                    }
                }
            }

            //Printing output array after sorting
            Console.WriteLine("\nOutput sorted array is: ");
            for (int i = 0; i < outputArr.Length; i++)
            {
                Console.Write(outputArr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int[][] arr =
            { new int[]{ 2, 6, 12, 34 },
              new int[]{ 1, 9, 20, 1000 },
              new int[]{ 23, 34, 90, 2000 }
            };
            Console.WriteLine("2D array length is: " + arr.Length + " ");
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total = total + arr[i].Length;
            }
            Console.WriteLine("\nTotal length is: " + total);
            int[] outputArr = new int[total];

            SortingOfTwoDArray.SortTwoDArray(arr, outputArr);
        }
    }

    /*
    Input 2D Array:
    2   6   12   34
    1   9   20   1000
    23  34  90   2000

    Step 1: Merge all elements into a 1D array.

    Output Array:
    2 6 12 34 1 9 20 1000 23 34 90 2000

    Step 2: Sort using Insertion Sort.

    Pass 1: 2 6 → No change
    Pass 2: 2 6 12 → No change
    Pass 3: 2 6 12 34 → No change
    Pass 4: Insert 1
    1 2 6 12 34 9 20 1000 23 34 90 2000

    Pass 5: Insert 9
    1 2 6 9 12 34 20 1000 23 34 90 2000

    Pass 6: Insert 20
    1 2 6 9 12 20 34 1000 23 34 90 2000

    Pass 7: Insert 1000 → No change

    Pass 8: Insert 23
    1 2 6 9 12 20 23 34 1000 34 90 2000

    Pass 9: Insert 34
    1 2 6 9 12 20 23 34 34 1000 90 2000

    Pass 10: Insert 90
    1 2 6 9 12 20 23 34 34 90 1000 2000

    Pass 11: Insert 2000 → No change

    Final Sorted Array:
    1 2 6 9 12 20 23 34 34 90 1000 2000
    */

}