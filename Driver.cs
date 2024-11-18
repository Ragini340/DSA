using DataStructure.tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            //ArrayPOC
            int[] arrayPOC = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("ArrayPOC: ");
            for (int i = 0; i < arrayPOC.Length; i++)
            {
                Console.Write(" " + arrayPOC[i]);
            }
            Console.WriteLine();

            //InsertionSort
            int[] insertionSortArr = { 1, 3, 2, 6, 8, 10, 9, 5 };
            Console.WriteLine("InsertionSort: ");
            InsertionSort.insertionSort(insertionSortArr);
            Console.WriteLine();

            //CountSortPOC
            int[] countSortPOCArr = { 3, 1, 4, 4, 2, 4, 2, 3, 1, 2 };
            Console.WriteLine("CountSortPOC: ");
            CountSortPOC.sortbyFreq(countSortPOCArr);
            Console.WriteLine();

            //MergeTwoSortedArrays
            int[] arr1 = { 2, 5, 7, 12, 20, 24, 29 };
            int[] arr2 = { 6, 9, 12, 14, 15, 19 };
            int[] arr3 = new int[arr1.Length + arr2.Length];

            MergeTwoSortedArrays.mergeTwoSortedArray(arr1, arr2, arr3);
            Console.WriteLine("MergeTwoSortedArrays: ");
            foreach (int sortedValue in arr3)
            {
                Console.Write(sortedValue + " ");
            }
            Console.WriteLine();

            //SelectionSort
            int[] selectionSortArr = { 1, 5, -1, 2, 3, -4 };
            SelectionSort.selectionSort(selectionSortArr);
            Console.WriteLine("SelectionSort: ");
            SelectionSort.printSortedArray(selectionSortArr);
            Console.WriteLine();

            //BinaryTreeTraversal
            Node root = new Node(1);
            root.left = new Node(2);
            root.left.left = new Node(4);
            root.left.right = new Node(3);
            root.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);
            Console.WriteLine("BinaryTreeTraversal:-");
            Console.WriteLine("Preorder traversal:");
            BinaryTreeTraversals.preorder(root);
            Console.WriteLine("Inorder traversal:");
            BinaryTreeTraversals.inorder(root);
            Console.WriteLine("Postorder traversal:");
            BinaryTreeTraversals.postorder(root);
            Console.WriteLine();

            //Mirror Tree
            root = new Node(5);
            root.left = new Node(3);
            root.right = new Node(6);
            root.left.left = new Node(2);
            root.left.right = new Node(4);
            MirrorTree.inorderTraversal(root);
            Console.WriteLine();
            Console.WriteLine("Mirror tree using inorder traversal:-");
            Node mirrorImageTree = MirrorTree.mirrorTree(root);
            MirrorTree.inorderTraversal(mirrorImageTree);

        }
    }

}
