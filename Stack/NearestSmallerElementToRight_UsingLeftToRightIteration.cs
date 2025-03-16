namespace DataStructure.Stack
{
    /*
     Brute force approach for nearest smaller element in right side. 
     Time Complexity: O(N^2)
     Space Complexity: O(1)
    */
    public class NearestSmallerElementToRight_UsingLeftToRightIteration
    {
        public static List<int> NearestSmallerElementToRightSide(List<int> inputList)
        {
            List<int> result = new List<int>(inputList.Count);

            //Iterating from left to right
            for (int i = 0; i <= inputList.Count - 1; i++)
            {
                bool found = false;
                for (int j = i + 1; j < inputList.Count; j++)
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
            List<int> result = NearestSmallerElementToRightSide(input);
            Console.WriteLine("Smaller right side nearest element for each elements: " + string.Join(", ", result));
        }

    }
}