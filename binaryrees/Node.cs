using System;
namespace binaryrees
{
    public class Node
    {

        public int value;
        public Node left;
        public Node right;

        public Node(int v)
        {
            this.value = v;
            left = null;
            right = null;
        }
        public void AddNode(Node n){
            if(this.value>n.value){
                if (this.left is null)this.left = n;
                else this.left.AddNode(n);
            }
            else if(this.value<n.value){
                if (this.right is null) this.right = n;
                else this.right.AddNode(n);
            }
        }

        public void search(int data)
        {
            if(this.value==data)Console.WriteLine("Element Found "+data);
            else if(data<this.value&&(this.left != null)){
                Console.WriteLine("Searching in left");
                this.left.search(data);  
            } 
            else if(data>this.value&&(this.right != null)) {
                Console.WriteLine("Searching in right");
                this.right.search(data);
            }

           
        }

        internal void traverseNode()
        {
            
        }
    }
}
