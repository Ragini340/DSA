﻿using DataStructure.Linkedlist;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class CheckIfLoopIsFoundInSingleLinkedList
    {
        /*Case1: To check if there is a loop found in the single linked list*/
        public bool findLoopInLinkedList(Node head)
        {
            Node slow = head;
            Node fast = head;
            bool isCycle = false;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    isCycle = true;
                    break;
                }
            }
            return isCycle;
        }

        /*Case2: To find start point point of a loop*/
        public Node findStartPointOfALoop(Node head)
        {
            Node slow = head;
            Node fast = head;
            bool isCycle = false;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    isCycle = true;
                    break;
                }
            }

            if (isCycle)
            {
                slow = head;
                while (true)
                {
                    if (slow == fast)
                    {
                        return fast;
                    }
                    slow = slow.next;
                    fast = fast.next;
                }
            }
            else
            {
                return null;
            }
        }

        public static void Main(string[] args)
        {
            Node head = new Node(3);
            head.next = new Node(9);
            head.next.next = new Node(7);
            head.next.next.next = new Node(2);

            Node temp = head.next.next.next.next = new Node(8);
            temp.next = new Node(4);
            temp.next.next = new Node(16);
            temp.next.next.next = new Node(26);
            temp.next.next.next.next = new Node(96);
            temp.next.next.next.next.next = new Node(94);

            Node temp1 = temp.next.next.next.next.next.next = new Node(400);
            temp1.next = new Node(400);
            temp1.next.next = new Node(200);
            temp1.next.next.next = new Node(213);
            temp1.next.next.next.next = new Node(100);
            temp1.next.next.next.next.next = new Node(500);

            Node temp2 = temp1.next.next.next.next.next.next = new Node(250);
            temp2.next = new Node(75);
            temp2.next.next = new Node(32);
            temp2.next.next.next = temp.next.next.next.next;

            //Case1: To check if there is a loop found in the single linked list
            CheckIfLoopIsFoundInSingleLinkedList checkIfLoopIsFoundInSingleLinkedList = new CheckIfLoopIsFoundInSingleLinkedList();
            bool isLoopFound = checkIfLoopIsFoundInSingleLinkedList.findLoopInLinkedList(head);
            Console.WriteLine("Is loop found in list ?" + isLoopFound);

            //Case2: To find start point point of a loop
            Node startLoop = checkIfLoopIsFoundInSingleLinkedList.findStartPointOfALoop(head);
            if (startLoop != null)
            {
                Console.WriteLine("Loop start node " + startLoop.data);
            }
            else
            {
                Console.WriteLine("There is no loop in the Single LinkedList");
            }
        }

    }
}