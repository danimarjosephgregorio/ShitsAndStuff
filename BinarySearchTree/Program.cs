using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        public static Node tree = null;

        static void Main(string[] args)
        {
            InitializeTree();

            Console.WriteLine("\n\nIn-order traversal: ");
            tree.InOrderTraversal();

            Console.WriteLine("\n\nPre-order traversal: ");
            tree.PreOrderTraversal();

            Console.WriteLine("\n\nPost-order traversal: ");
            tree.PostOrderTraversal();

            Console.Write($"\n\nTree contains {18}: {tree.Contains(18)}");

            var node = tree.FindRecursive(10);
            Console.Write($"\n\nFind node recursively: {node.Data} || Count: {node.Count}");

            Console.Write($"\n\nFind node non-recursively: {tree.Find(66).Data}");

            Console.ReadLine();
        }

        public static void InitializeTree()
        {
            tree = new Node(50);
            tree.Insert(22);
            tree.Insert(33);
            tree.Insert(44);
            tree.Insert(99);
            tree.Insert(77);
            tree.Insert(88);
            tree.Insert(66);
            tree.Insert(55);
            tree.Insert(77);
            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(80);
            tree.Insert(60);
            tree.Insert(90);
            tree.Insert(10);
            tree.Insert(67);
            tree.Insert(89);
            tree.Insert(18);
            tree.Insert(23);
            tree.Insert(82);
            tree.Insert(1);
            tree.Insert(100);
        }
    }
}
