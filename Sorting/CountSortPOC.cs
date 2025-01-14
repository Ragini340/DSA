namespace DataStructure.Sorting
{
    public class CountSortPOC
    {
        public static void SortbyFreq(int[] arr)
        {
            int[] freq = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                int index = arr[i];
                freq[index]++;
            }
            Console.WriteLine("Count sort in ascending order:-");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= freq[i]; j++)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nCount sort in decreasing order:-");
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= freq[i]; j++)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void Main(string[] args)
        {
            int[] countSortPOCArr = { 3, 1, 4, 4, 2, 4, 2, 3, 1, 2 };
            CountSortPOC.SortbyFreq(countSortPOCArr);
        }

    }
}