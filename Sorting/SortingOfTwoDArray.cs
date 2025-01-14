namespace DataStructure.Sorting
{
    /*
     Merge 2-dimensional sorted arrays into one 1-Dimesional output array and sort the output array using any sorting algorithm.
     Time Complexity:
     Space Complexity:
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

}