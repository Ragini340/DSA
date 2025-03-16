namespace DataStructure.Stack
{
    /*
	 Nearest greater element in the right hand side.
	 Traverse from right to left to get right hand side greater element.
    */
    public class NearestGreaterElementToRight
    {
        public static List<int> NearestGreaterElementRightSide(List<int> input)
        {
            List<int> result = new List<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                //Pop all less than equal to elements 
                while (stack.Count > 0 && stack.Peek() <= input[i])
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
                stack.Push(input[i]);
            }

            //Reverse result to traverse element from left to right
            result.Reverse();
            return result;
        }

        public static void Main(string[] args)
        {
            List<int> input = new List<int> { 9, 7, 3, 5, 4, 2, 6, 1, 8 };
            List<int> result = NearestGreaterElementRightSide(input);
            Console.WriteLine("Nearest greater element in right for the given each list's element: " + string.Join(", ", result));
        }

    }
}