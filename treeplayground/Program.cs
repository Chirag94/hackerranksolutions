using System;

namespace treeplayground
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Tree tree = new Tree(new Node(5));
            Random random = new Random();
            //for (int i = 0; i < 10;i++){
            //    tree.AddNode(i++);
            //}
            tree.AddNode(2);
            tree.AddNode(1);
            tree.AddNode(3);
            tree.AddNode(12);
            tree.AddNode(9);
            tree.AddNode(21);
            tree.AddNode(19);
            tree.AddNode(25);
            //tree.AddNode(12)
            tree.traverse();
            //tree.search(4);
            foreach(var i in Node.Values){
                Console.Write(i+"\t");
            }
            int p1 = 3;
            int p2 = 9;
            tree.findMinDistance(5,25);
            Console.WriteLine("Distance is :"+(Node.distance));
            }
    }
}
