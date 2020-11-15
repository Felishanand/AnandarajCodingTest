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

            Console.ReadLine();
        }
    }
}