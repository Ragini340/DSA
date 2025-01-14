namespace DataStructure.Sorting
{
    public class InsertionSort
    {
        public static void insertionSort(int[] arr)
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
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }

        public static void Main(string[] args)
        {
            int[] insertionSortArr = { 1, 3, 2, 6, 8, 10, 9, 5 };
            Console.WriteLine("Insertion sorting: ");
            InsertionSort.insertionSort(insertionSortArr);
        }

    }
}