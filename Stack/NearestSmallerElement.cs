namespace DataStructure.Stack
{
    /*
     For the given list find the nearest smaller element in the left hand side.
     If there is no nearest smaller element in the left hand side then use the default value as -1.
    */
    /*
     Time Complexity: O(N^2) 
     Space Complexity: O(1)
    */
    public class NearestSmallerElement
    {
        public static List<int> NearestSmallerUsingBruteForce(List<int> inputList)
        {
            List<int> result = new List<int>(inputList.Count);
            result.Add(-1);
            for (int i = 1; i < inputList.Count; i++)
            {
                bool found = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (inputList[j] < inputList[i])
                    {
                        result.Add(inputList[j]);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    result.Add(-1);
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            List<int> input = new List<int> { 4, 6, 10, 11, 7, 6, 3, 5 };
            List<int> bfResult = NearestSmallerUsingBruteForce(input);
            Console.WriteLine("Smaller left side nearest element for each elements: " + string.Join(", ", bfResult));
        }

    }
}