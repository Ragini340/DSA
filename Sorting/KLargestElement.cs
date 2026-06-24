namespace DataStructure.Sorting
{
    /*
     You are given an unsorted array containing ‘N’ integers. You need to find ‘K’ largest elements from the given array. 
     Also, you need to return the elements in non-decreasing order.
     */

    /*
    TIME COMPLEXITY
    TC = O(K × N) + O(N²)
    Since K ≤ N,
    TC = O(N²)

    SPACE COMPLEXITY
    SC = O(1)
    (No extra array is created. Sorting is done in-place.)
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
        /*
        Input:
        arr = {1, 5, -1, 2, 3, -4}
        B = 4

        -----------------------------------
        FindKthLargestElement(arr, 4)
        -----------------------------------

        Initial Array:
        [1, 5, -1, 2, 3, -4]

        PASS 1 (i = 0)

        Find maximum from index 0 to 5

        1 -> max = 1
        5 -> max = 5 (index 1)
        -1 -> ignore
        2 -> ignore
        3 -> ignore
        -4 -> ignore

        Swap arr[0] and arr[1]

        Array:
        [5, 1, -1, 2, 3, -4]

        -----------------------------------

        PASS 2 (i = 1)

        Find maximum from index 1 to 5

        1 -> max = 1
        -1 -> ignore
        2 -> max = 2 (index 3)
        3 -> max = 3 (index 4)
        -4 -> ignore

        Swap arr[1] and arr[4]

        Array:
        [5, 3, -1, 2, 1, -4]

        -----------------------------------

        PASS 3 (i = 2)

        Find maximum from index 2 to 5

        -1 -> max = -1
        2 -> max = 2 (index 3)
        1 -> ignore
        -4 -> ignore

        Swap arr[2] and arr[3]

        Array:
        [5, 3, 2, -1, 1, -4]

        -----------------------------------

        PASS 4 (i = 3)

        Find maximum from index 3 to 5

        -1 -> max = -1
        1 -> max = 1 (index 4)
        -4 -> ignore

        Swap arr[3] and arr[4]

        Array:
        [5, 3, 2, 1, -1, -4]

        -----------------------------------

        Return A[B-1]

        A[4-1] = A[3] = 1

        Output:
        Nth largest element = 1

        -----------------------------------
        InsertionSort()
        -----------------------------------

        Input Array:
        [5, 3, 2, 1, -1, -4]

        i = 1
        Swap 5 and 3

        [3, 5, 2, 1, -1, -4]

        -----------------------------------

        i = 2

        Swap 5 and 2

        [3, 2, 5, 1, -1, -4]

        Swap 3 and 2

        [2, 3, 5, 1, -1, -4]

        -----------------------------------

        i = 3

        Swap 5 and 1

        [2, 3, 1, 5, -1, -4]

        Swap 3 and 1

        [2, 1, 3, 5, -1, -4]

        Swap 2 and 1

        [1, 2, 3, 5, -1, -4]

        -----------------------------------

        i = 4

        Swap 5 and -1

        [1, 2, 3, -1, 5, -4]

        Swap 3 and -1

        [1, 2, -1, 3, 5, -4]

        Swap 2 and -1

        [1, -1, 2, 3, 5, -4]

        Swap 1 and -1

        [-1, 1, 2, 3, 5, -4]

        -----------------------------------

        i = 5

        Swap 5 and -4

        [-1, 1, 2, 3, -4, 5]

        Swap 3 and -4

        [-1, 1, 2, -4, 3, 5]

        Swap 2 and -4

        [-1, 1, -4, 2, 3, 5]

        Swap 1 and -4

        [-1, -4, 1, 2, 3, 5]

        Swap -1 and -4

        [-4, -1, 1, 2, 3, 5]

        -----------------------------------

        Final Sorted Array:

        [-4, -1, 1, 2, 3, 5]

        Output:
        The elements in non-decreasing order are:
        -4 -1 1 2 3 5
        */
    }
}