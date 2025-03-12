namespace DataStructure.Array
{
    /*
    You are given an array A of N integers. Return a 2D array consisting of all the subarrays of the array.
    Note : The order of the subarrays in the resulting 2D array does not matter.

    Problem Constraints
    1 <= N <= 100
    1 <= A[i] <= 10^5

    Input Format:
    First argument A is an array of integers. Output Format Return a 2D array of integers in any order.

    Example Input:-
    Input 1: A = [1, 2, 3]
    Input 2: A = [5, 2, 1, 4]

    Example Output:- 
    Output 1:
    [[1], [1, 2], [1, 2, 3], [2], [2, 3], [3]]
    Output 2:
    [[1], [1, 4], [2], [2, 1], [2, 1, 4], [4], [5], [5, 2], [5, 2, 1], [5, 2, 1, 4]]

    Example Explanation
    For Input 1:
    All the subarrays of the array are returned. There are a total of 6 subarrays.
    For Input 2:
    All the subarrays of the array are returned. There are a total of 10 subarrays.
    */

    //Time Complexity: O(N^2)
    public class GenerateAllSubArrays
    {
        List<List<int>> FindAllSubArrays(int[] arr)
        {
            List<List<int>> subArrays = new List<List<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                List<int> subArray = new List<int>();
                for (int j = i; j < arr.Length; j++)
                {
                    subArray.Add(arr[j]);
                    subArrays.Add(new List<int>(subArray));
                }
            }

            Console.Write("[");
            foreach (var item in subArrays)
            {
                Console.Write($"[{string.Join(", ", item)}]");
            }
            Console.WriteLine("]");

            return subArrays;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Elements of array are:-");
            for (int i = 0; i < length; i++)
            {
                Console.Write("Array element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            GenerateAllSubArrays generateAllSubArrays = new GenerateAllSubArrays();
            generateAllSubArrays.FindAllSubArrays(arr);
        }

    }
}