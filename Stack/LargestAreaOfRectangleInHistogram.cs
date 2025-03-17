namespace DataStructure.Stack
{
    /*
     Given a list of integers A.
     A represents a histogram i.e A[i] denotes the height of the i'th histogram's bar. Width of each bar is 1.
     Find the area of the largest rectangle formed by the histogram.

     Problem Constraints:
     1 <= |A| <= 100000
     1 <= A[i] <= 1000000000

     input  A = { 2, 1, 5, 6, 2, 3 } 
     output: 10 
     input A = { 2, 1, 4, 7, 5, 2, 1, 3, 4, 5, 6, 4, 3, 2, 3, 1, 5, 6, 4, 2 }
     output: 20 
   */
    /*
     Time Complexity: O(N)
     Space Complexity: O(N)
    */
    public class LargestAreaOfRectangleInHistogram
    {
        List<int> leftSmaller;
        List<int> rightSmaller;

        public LargestAreaOfRectangleInHistogram()
        {
            leftSmaller = new List<int>();
            rightSmaller = new List<int>();
        }

        public List<int> FindLeftSmaller(List<int> inputList)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                while (stack.Count > 0 && (inputList[stack.Peek()] >= inputList[i]))
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    leftSmaller.Add(-1);
                }
                else
                {
                    leftSmaller.Add(stack.Peek());
                }
                stack.Push(i);
            }
            return leftSmaller;
        }

        public List<int> FindRightSmaller(List<int> inputList)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = inputList.Count - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && (inputList[stack.Peek()] >= inputList[i]))
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    rightSmaller.Add(inputList.Count);
                }
                else
                {
                    rightSmaller.Add(stack.Peek());
                }
                stack.Push(i);
            }
            rightSmaller.Reverse();
            return rightSmaller;
        }

        public int LargestArea(List<int> heightOfHistograms)
        {
            FindLeftSmaller(heightOfHistograms);
            FindRightSmaller(heightOfHistograms);
            int result = 0;

            for (int i = 0; i < heightOfHistograms.Count; i++)
            {
                int heightOfHistogram = heightOfHistograms[i];
                int maxWidthPossible = heightOfHistogram * (rightSmaller[i] - leftSmaller[i] - 1);
                result = Math.Max(result, maxWidthPossible);
            }
            return result;
        }

        public static void Main(string[] args)
        {
            LargestAreaOfRectangleInHistogram largestAreaOfRectangle = new LargestAreaOfRectangleInHistogram();
            List<int> heightOfHistograms = new List<int> { 2, 1, 4, 7, 5, 2, 1, 3, 4, 5, 6, 4, 3, 2, 3, 1, 5, 6, 4, 2 };
            int area = largestAreaOfRectangle.LargestArea(heightOfHistograms);
            Console.WriteLine("The area of the largest rectangle formed by the histogram is: " + area);
        }

    }
}