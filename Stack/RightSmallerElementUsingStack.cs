namespace DataStructure.Stack
{
    public class RightSmallerElementUsingStack
    {
        public static List<int> NearestSamllerElementToRight(List<int> input)
        {
            List<int> result = new List<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                //Pop all less than equal to elements 
                while (stack.Count > 0 && stack.Peek() >= input[i])
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
            List<int> input = new List<int> { 4, 6, 10, 11, 7, 3, 5 };
            List<int> result = NearestSamllerElementToRight(input);
            Console.WriteLine("Nearest smaller element in right for the given each list's element: " + string.Join(", ", result));
        }

    }
}