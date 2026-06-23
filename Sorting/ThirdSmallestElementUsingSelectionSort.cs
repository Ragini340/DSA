namespace DataStructure.Sorting
{
    /*
    Time Complexity: O(N^2)
    Outer loop runs B times.
    Inner loop scans up to N elements each time.
    Therefore, TC = O(B × N).
    In the worst case, when B = N, TC = O(N²).

    Space Complexity (SC):
    Only a few extra variables (min_index, min_element, temp) are used.
    No additional data structures are created.
    Therefore, SC = O(1) (constant extra space).
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

        /*
        Dry Run

        Input:
        A = {1, 5, -1, 2, 3, -4}
        B = 3

        We need to find the 3rd smallest element.

        Pass 1 (i = 0)

        Initial:
        min_element = 1
        min_index = 0

        Comparisons:
        5  > 1   → No change
        -1 < 1   → min_element = -1, min_index = 2
        2  > -1  → No change
        3  > -1  → No change
        -4 < -1  → min_element = -4, min_index = 5

        Swap A[0] and A[5]

        Array:
        [-4, 5, -1, 2, 3, 1]

        Pass 2 (i = 1)

        Initial:
        min_element = 5
        min_index = 1

        Comparisons:
        -1 < 5  → min_element = -1, min_index = 2
        2  > -1 → No change
        3  > -1 → No change
        1  > -1 → No change

        Swap A[1] and A[2]

        Array:
        [-4, -1, 5, 2, 3, 1]

        Pass 3 (i = 2)

        Initial:
        min_element = 5
        min_index = 2

        Comparisons:
        2 < 5 → min_element = 2, min_index = 3
        3 > 2 → No change
        1 < 2 → min_element = 1, min_index = 5

        Swap A[2] and A[5]

        Array:
        [-4, -1, 1, 2, 3, 5]

        Result:
        A[B - 1] = A[2] = 1

        Therefore, the 3rd smallest element is 1.
        */
    }
}