namespace DataStructure.Stack
{
    /*
     For the given list find the nearest greater element in the left hand side.
     If there is no nearest greater element in the left hand side then use default value as -1.
    */
    public class NearestGreaterElementToLeft
    {
        public static List<int> NearestGreaterElementToLeftSide(List<int> inputList)
        {
            List<int> result = new List<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < inputList.Count; i++)
            {
                //Pop all less than or equal elements
                while (stack.Count > 0 && stack.Peek() <= inputList[i])
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
            List<int> input = new List<int> { 9, 7, 3, 5, 4, 2, 6, 1, 8 };
            List<int> result = NearestGreaterElementToLeftSide(input);
            Console.WriteLine("Nearest greater element in left for the given each list's element: " + string.Join(", ", result));
        }

    }
}