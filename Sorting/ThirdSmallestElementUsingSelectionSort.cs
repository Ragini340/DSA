namespace DataStructure.Sorting
{
    /*
      Time Complexity: O(N^2)
    */
    public class ThirdSmallestElementUsingSelectionSort
    {
        //Find kth smallest element from array without using in-built function
        public static int FindSmallestElement(int[] A, int B)
        {
            for (int i = 0; i < B; i++)
            {
                int min_index = i;
                int min_element = A[i];
                for (int j = i; j < A.Length; j++)
                {
                    if (A[j] < min_element)
                    {
                        min_element = A[j];
                        min_index = j;
                    }
                }
                int temp = A[i];
                A[i] = A[min_index];
                A[min_index] = temp;
            }

            return A[B - 1];
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 5, -1, 2, 3, -4 };
            int result = FindSmallestElement(arr, 3);
            Console.WriteLine("Nth samllest element is: " + result);
        }

    }
}