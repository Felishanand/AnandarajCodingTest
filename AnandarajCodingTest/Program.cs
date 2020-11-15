using AnandarajCodingTest.Interface;
using AnandarajCodingTest.Model;
using AnandarajCodingTest.Task;
using System;
using System.Collections.Generic;

namespace AnandarajCodingTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Anandaraj Coding Test - 9940895758");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice: \n 1.Binary Search: \n 2.Palindrome");
            Console.WriteLine("");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case (int)TaskEnum.BinarySearchTree:
                    BinarySearchTree();
                    break;

                case (int)TaskEnum.Palindrome:
                    PermutionofPalidrome();
                    break;

                default:
                    break;
            }

            Console.ReadLine();
        }

        private static void PermutionofPalidrome()
        {
            throw new NotImplementedException();
        }

        private static void BinarySearchTree()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

            var isBinarySearchTree = binarySearchTree.IsBinarySearchTree();

            Console.WriteLine(".......................Result......................");

            if (isBinarySearchTree)
            {
                Console.WriteLine("It is Binary Search Tree");
            }
            else
            {
                Console.WriteLine("It is Not Binary Search Tree");
            }
        }
    }
}