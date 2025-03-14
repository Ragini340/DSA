namespace DataStructure.Stack
{
    /*
     For the given list find the nearest smaller element in the left hand side.
     If there is no nearest smaller element in the left hand side then use the default value as -1.
    */
    /*
     Time Complexity: O(n) 
     Space Complexity: O(n)
    */
    public class NearestSmallerElementUsingStack
    {
        public static List<int> NearestSmallerElement(List<int> inputList)
        {
            Stack<int> stack = new Stack<int>();
            List<int> result = new List<int>(inputList.Count);

            for (int i = 0; i < inputList.Count; i++)
            {
                //Pop all greater than equal element from stack
                while (stack.Count > 0 && (stack.Peek() >= inputList[i]))
                {
                    stack.Pop();
                }

                //Update result
                if (stack.Count == 0)
                {
                    result.Add(-1);
                }
                else
                {
                    result.Add(stack.Peek());
                }

                //Push element in stack
                stack.Push(inputList[i]);
            }
            return result;
        }

        public static void Main(string[] args)
        {
            List<int> input = new List<int> { 4, 6, 10, 11, 7, 6, 3, 5 };
            List<int> result = NearestSmallerElement(input);
            Console.WriteLine("Smaller left side nearest element for each elements: " + string.Join(", ", result));
        }

    }
}