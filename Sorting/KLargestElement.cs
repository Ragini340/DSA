namespace DataStructure.Sorting
{
    /*
     You are given an unsorted array containing ‘N’ integers. You need to find ‘K’ largest elements from the given array. 
     Also, you need to return the elements in non-decreasing order.
     */
    public class KLargestElement
    {
        public static int FindKthLargestElement(int[] A, int B)
        {
            for (int i = 0; i < B; i++)
            {
                int max_index = i;
                int max_element = A[i];
                for (int j = i; j < A.Length; j++)
                {
                    if (A[j] > max_element)
                    {
                        max_element = A[j];
                        max_index = j;
                    }
                }
                int temp = A[i];
                A[i] = A[max_index];
                A[max_index] = temp;
            }

            return A[B - 1];
        }

        //Sorting using insertion sort 
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nThe elements in non-decreasing order are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            return arr;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 5, -1, 2, 3, -4 };
            int result = FindKthLargestElement(arr, 4);
            Console.WriteLine("Nth largest element is: " + result);
            InsertionSort(arr);
        }

    }
}