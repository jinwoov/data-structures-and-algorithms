﻿using FizzBuzzTree.Classes;
using System;

namespace FizzBuzzTree
{
    class Program
    {
        /// <summary>
        /// This method creates the tree and add child and runs the method and outputs whats in the tree
        /// </summary>
        static void Main()
        {
            BinarySearchTree bst = new BinarySearchTree(5);
            bst.Add(bst.Root, 15);
            bst.Add(bst.Root, 5);
            bst.Add(bst.Root, 7);
            bst.Add(bst.Root, 3);
            bst.Add(bst.Root, 9);
            bst.Add(bst.Root, 12);
            bst.Add(bst.Root, 20);
            bst.Add(bst.Root, 150);


            BinarySearchTree bts = FizzBuzzTree(bst);
            BinaryTree bt = new BinaryTree();

            string[] stringBTS = bt.StringOrder(bts.Root);

            foreach (var item in stringBTS)
            {
                Console.Write($"{item} => ");
            }
            Console.Write("END");
        }

        static Node Traverse(Node node)
        {
            if (node == null)
            {
                return node;
            }
            if (node.Value % 5 == 0 && node.Value % 3 == 0)
            {
                node.StringValue = "Fizz Buzz";
            }
            else if (node.Value % 3 == 0)
            {
                node.StringValue = "Fizz";
            }
            else if (node.Value % 5 == 0)
            {
                node.StringValue = "Buzz";
            }
            else
            {
                node.StringValue = $"{node.Value}";
            }

            Traverse(node.Left);
            Traverse(node.Right);
            return node;
        }

        static BinarySearchTree FizzBuzzTree(BinarySearchTree bts)
        {
            Traverse(bts.Root);

            return bts;
        }
    }
}
