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
/*
Input:
A = {2,1,5,6,2,3}

Step 1: Find Left Smaller Index

Stack stores INDEXES.

i = 0, height = 2
Stack = []
No smaller element
leftSmaller = [-1]
Push 0
Stack = [0]

------------------------------------------------

i = 1, height = 1

Stack Top = index 0 (height = 2)

2 >= 1
Pop 0

Stack becomes empty

leftSmaller = [-1,-1]

Push index 1

Stack = [1]

------------------------------------------------

i = 2, height = 5

Top = index 1 (height =1)

1 < 5

leftSmaller = [-1,-1,1]

Push 2

Stack = [1,2]

------------------------------------------------

i = 3, height = 6

Top = index2 (height5)

5 < 6

leftSmaller = [-1,-1,1,2]

Push3

Stack=[1,2,3]

------------------------------------------------

i=4 height=2

Top=3 height6
6>=2 Pop

Top=2 height5
5>=2 Pop

Top=1 height1
1<2 Stop

leftSmaller=[-1,-1,1,2,1]

Push4

Stack=[1,4]

------------------------------------------------

i=5 height=3

Top=4 height2

2<3

leftSmaller=[-1,-1,1,2,1,4]

Push5

Stack=[1,4,5]

Final Left Smaller

Index :        0 1 2 3 4 5
Height:        2 1 5 6 2 3
Left Smaller: -1 -1 1 2 1 4

=================================================

Step 2 : Find Right Smaller

Traverse from Right to Left

i=5 height3

Stack=[]

right=6

Push5

Stack=[5]

------------------------------------------------

i=4 height2

Top=5 height3

3>=2 Pop

Stack empty

right=6

Push4

Stack=[4]

------------------------------------------------

i=3 height6

Top=4 height2

2<6

right=4

Push3

Stack=[4,3]

------------------------------------------------

i=2 height5

Top=3 height6

6>=5 Pop

Top=4 height2

2<5

right=4

Push2

Stack=[4,2]

------------------------------------------------

i=1 height1

Top=2 height5
Pop

Top=4 height2
Pop

Stack Empty

right=6

Push1

Stack=[1]

------------------------------------------------

i=0 height2

Top=1 height1

1<2

right=1

Push0

Stack=[1,0]

Collected (reverse order)

[6,6,4,4,6,1]

After Reverse

Right Smaller

Index :         0 1 2 3 4 5
Right Smaller : 1 6 4 4 6 6

=================================================

Step 3 : Calculate Area

Formula

Area = Height × (Right - Left - 1)

------------------------------------------------

Index 0

Height =2

Left=-1

Right=1

Width=1-(-1)-1

=1

Area=2×1=2

Maximum=2

------------------------------------------------

Index1

Height=1

Left=-1

Right=6

Width=6

Area=6

Maximum=6

------------------------------------------------

Index2

Height=5

Left=1

Right=4

Width=2

Area=10

Maximum=10

------------------------------------------------

Index3

Height=6

Left=2

Right=4

Width=1

Area=6

Maximum=10

------------------------------------------------

Index4

Height=2

Left=1

Right=6

Width=4

Area=8

Maximum=10

------------------------------------------------

Index5

Height=3

Left=4

Right=6

Width=1

Area=3

Maximum=10

=================================================

Final Answer

Largest Rectangle Area = 10

-------------------------------------------------

Summary

Height        : 2 1 5 6 2 3
Left Smaller  : -1 -1 1 2 1 4
Right Smaller : 1 6 4 4 6 6
Area          : 2 6 10 6 8 3

Maximum Area = 10
---------------------------------------------
*/