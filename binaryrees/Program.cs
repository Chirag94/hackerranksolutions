using System;

namespace binaryrees
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tree tree = new Tree();
            tree.AddNode(new Node(10));
            tree.AddNode(new Node(1));
            tree.AddNode(new Node(11));
            tree.AddNode(new Node(10));
            tree.AddNode(new Node(5));
            tree.AddNode(new Node(3));
            tree.AddNode(new Node(12));
            tree.AddNode(new Node(111));
            tree.AddNode(new Node(0));
            tree.traverse();
            tree.SearchNode(111);
            Console.WriteLine(tree);




        }
    }
}
 