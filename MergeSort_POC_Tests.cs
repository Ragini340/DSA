using DataStructure.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DSA_Test_Project
{
    [TestClass]
    public class MergeSort_POC_Tests
    {
        //Test case to verify MergeSort with a simple unsorted array
        [TestMethod]
        public void TestMergeSort_SimpleArray()
        {
            //Arrange
            int[] input = { 38, 27, 43, 3, 9, 82, 10 };
            int[] expected = { 3, 9, 10, 27, 38, 43, 82 };

            //Act
            MergeSort_POC.MergeSort(input);

            //Assert
            CollectionAssert.AreEqual(expected, input);
        }

        //Test case for an already sorted array
        [TestMethod]
        public void TestMergeSort_SortedArray()
        {
            //Arrange
            int[] input = { 1, 2, 3, 4, 5, 6, 7 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };

            //Act
            MergeSort_POC.MergeSort(input);

            //Assert
            CollectionAssert.AreEqual(expected, input);
        }

        //Test case for an array with all elements the same
        [TestMethod]
        public void TestMergeSort_EqualElements()
        {
            //Arrange
            int[] input = { 5, 5, 5, 5, 5 };
            int[] expected = { 5, 5, 5, 5, 5 };

            //Act
            MergeSort_POC.MergeSort(input);

            //Assert
            CollectionAssert.AreEqual(expected, input);
        }

        //Test case for an empty array
        [TestMethod]
        public void TestMergeSort_EmptyArray()
        {
            //Arrange
            int[] input = { };
            int[] expected = { };

            //Act
            MergeSort_POC.MergeSort(input);

            //Assert
            CollectionAssert.AreEqual(expected, input);
        }

        //Test case for an array with one element
        [TestMethod]
        public void TestMergeSort_SingleElementArray()
        {
            //Arrange
            int[] input = { 42 };
            int[] expected = { 42 };

            //Act
            MergeSort_POC.MergeSort(input);

            //Assert
            CollectionAssert.AreEqual(expected, input);
        }

        //Test case for a reverse sorted array
        [TestMethod]
        public void TestMergeSort_ReverseSortedArray()
        {
            //Arrange
            int[] input = { 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };

            //Act
            MergeSort_POC.MergeSort(input);

            //Assert
            CollectionAssert.AreEqual(expected, input);
        }

    }
}