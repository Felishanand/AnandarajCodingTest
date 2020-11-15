using System;
using System.Collections.Generic;
using System.Text;

namespace AnandarajCodingTest.Task
{
    public class ReverseLinkedList
    {
        private Node head;

        private class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        // function to add a new node at
        // the end of the list
        private void AddNode(Node node)
        {
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        // function to reverse the list
        private void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        // function to print the list data
        private void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        public void Main(int totalCount)
        {
            Console.WriteLine("Enter a Number");
            for (int i = 0; i < totalCount; i++)
            {
                AddNode(new Node(Convert.ToInt32(Console.ReadLine())));
            }

            Console.WriteLine("Given Linked List");
            PrintList();

            ReverseList();

            Console.WriteLine("Reverse Linked List");
            PrintList();
        }
    }
}