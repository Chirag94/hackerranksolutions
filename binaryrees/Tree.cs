using System;
namespace binaryrees
{
    public class Tree
    {
        private Node root;
        public Tree()
        {
            this.root = null;
        }
        public void AddNode(Node n){
            if (this.root == null) this.root = n;
            else this.root.AddNode(n);

        }
        public void  SearchNode(int data){
            if (this.root.value== data) Console.WriteLine("Found at root level only: "+data);

            else {

            Console.WriteLine("Searching for other nodes");
                this.root.search(data);
            }
        }

        internal void traverse()
        {
            if (this.root != null){
                if (this.root.left !=null){
                    this.root.left.traverseNode();
                }
                if (this.root.right != null)
                {
                    this.root.left.traverseNode();
                }
            }
        }
    }
}
