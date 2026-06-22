namespace DataStructure.Sorting
{
    /*Time Complexity = O(n) * O(n) = O(n2)
    Space Complexity = O(1)
    Output: -4 -1 1 2 3 5
    */
    public class SelectionSort
    {
        public static void SelectionSorts(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minElementIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minElementIndex] > arr[j])
                    {
                        minElementIndex = j;
                    }
                }

                //Swap arr[i], arr[minElementIndix]
                int temp = arr[i];
                arr[i] = arr[minElementIndex];
                arr[minElementIndex] = temp;
            }
        }

        //Print sorted array
        public static void PrintSortedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void Main(string[] args)
        {
            int[] selectionSortArr = { 1, 5, -1, 2, 3, -4 };
            SelectionSort.SelectionSorts(selectionSortArr);
            Console.WriteLine("Selection sorting: ");
            SelectionSort.PrintSortedArray(selectionSortArr);
        }
/*
Initial Array:
[1, 5, -1, 2, 3, -4]

Pass 1 (i = 0)
Minimum Element = -4
Swap 1 and -4
[-4, 5, -1, 2, 3, 1]

Pass 2 (i = 1)
Minimum Element = -1
Swap 5 and -1
[-4, -1, 5, 2, 3, 1]

Pass 3 (i = 2)
Minimum Element = 1
Swap 5 and 1
[-4, -1, 1, 2, 3, 5]

Pass 4 (i = 3)
Minimum Element = 2
No Swap Needed
[-4, -1, 1, 2, 3, 5]

Pass 5 (i = 4)
Minimum Element = 3
No Swap Needed
[-4, -1, 1, 2, 3, 5]

Final Sorted Array:
[-4, -1, 1, 2, 3, 5]

Output:
-4 -1 1 2 3 5
*/
    }
}