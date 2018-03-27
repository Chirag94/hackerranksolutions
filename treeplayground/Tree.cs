using System;
namespace treeplayground
{
    public class Tree
    {
        public Node root { set; get; }
        public Tree(Node node)
        {
            if (this.root is null) this.root = node;
        }
        public Tree(){}
        public void AddNode(int data){
            this.root.AddNode(new Node(data));
        }

        internal void traverse()
        {
            this.root.traverseNode();
            Console.WriteLine("");
        }

        internal void search(int v)
        {
            this.root.searchelement(v);
        }

        internal void findMinDistance(int p1, int p2)
        {
            this.root.findDistance(p1, p2);
        }
    }
}
