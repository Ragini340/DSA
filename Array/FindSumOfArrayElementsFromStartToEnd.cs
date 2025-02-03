namespace DataStructure.Array
{
    public class FindSumOfArrayElementsFromStartToEnd
    {
        public void SumOfArrayElementsFromStartToEnd(int[] arr, int[][] arr1)
        {
            for (int j = 0; j < arr1.Length; j++)
            {
                int startIdx = arr1[j][0];
                int endIdx = arr1[j][1];
                int sum = 0;
                for (int i = startIdx; i <= endIdx; i++)
                {
                    sum = sum + arr[i];
                }
                Console.WriteLine(sum);
            }
        }

        public static void Main(string[] args)
        {
            int[] arr = { -3, 6, 2, 4, 5, 2, 8, -9, 3 };
            int[][] arr1 =
            { new int[]{ 1, 3 },
              new int[]{ 2, 7 },
              new int[]{ 4, 8 },
              new int[] {0, 2 }
            };

            FindSumOfArrayElementsFromStartToEnd obj = new FindSumOfArrayElementsFromStartToEnd();
            obj.SumOfArrayElementsFromStartToEnd(arr, arr1);
        }

    }
}