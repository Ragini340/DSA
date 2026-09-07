using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    /*Implement a Queue using two Stacks. The Queue should support Enqueue, Dequeue,
      and Peek operations following the FIFO (First In First Out) principle.*/
    /*
    Time Complexity (TC):
    Enqueue: O(1)
    Dequeue: O(1) amortized
    Peek: O(1) amortized

    Explanation:
    Elements are added to the input stack.
    When Dequeue or Peek is called and the output stack is empty,
    all elements are moved from the input stack to the output stack.
    Each element is moved at most once between the two stacks.

    Therefore, Dequeue and Peek have O(1) amortized time complexity.

    Space Complexity (SC):
    O(n)

    Explanation:
    We use two stacks to store the queue elements.
    In the worst case, both stacks together contain n elements.
*/
    public class ImplementQueueUsingTwoStacks
    {
        private readonly Stack<int> inputStack = new Stack<int>();
        private readonly Stack<int> outputStack = new Stack<int>();

        public void Enqueue(int value)
        {
            inputStack.Push(value);
        }

        public int Dequeue()
        {
            MoveElementsIfRequired();

            if (outputStack.Count == 0)
            {
                return -1;
            }

            return outputStack.Pop();
        }

        public int Peek()
        {
            MoveElementsIfRequired();

            if (outputStack.Count == 0)
            {
                return -1;
            }

            return outputStack.Peek();
        }

        private void MoveElementsIfRequired()
        {
            if (outputStack.Count == 0)
            {
                while (inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }
            }
        }

        public static void Main(string[] args)
        {
            ImplementQueueUsingTwoStacks queue = new ImplementQueueUsingTwoStacks();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }
    }
}