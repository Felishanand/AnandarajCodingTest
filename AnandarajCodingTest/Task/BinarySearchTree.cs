using AnandarajCodingTest.Interface;
using AnandarajCodingTest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnandarajCodingTest.Task
{
    public class BinarySearchTree
    {
        private class Node
        {
            public int data;
            public Node left, right;

            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        };

        // Function to check if Binary Tree is BST
        private static bool isBST(Node root)
        {
            int prev = int.MinValue;
            return isBSTUtil(root, prev);
        }

        // Utility function to check if Binary Tree is BST
        private static bool isBSTUtil(Node root, int prev)
        {
            // traverse the tree in inorder fashion and
            // keep track of prev node
            if (root != null)
            {
                if (!isBSTUtil(root.left, prev))
                    return false;

                // Allows only distinct valued nodes
                if (root.data <= prev)
                    return false;

                // Initialize prev to current
                prev = root.data;

                return isBSTUtil(root.right, prev);
            }

            return true;
        }

        public bool IsBinarySearchTree()
        {
            Console.WriteLine("Enter Node Root:");
            Node root = new Node(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter Left Node:");
            root.left = new Node(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter Right Node");
            root.right = new Node(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter Left in Left Node");
            root.left.left = new Node(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter Left in Right Node");
            root.left.right = new Node(Convert.ToInt32(Console.ReadLine()));

            if (isBST(root))
                return true;
            else
                return false;
        }
    }
}