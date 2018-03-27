using System;
using System.Collections.Generic;

namespace treeplayground
{
    public class Node
    {
        public int Data { set; get; }
        public Node left { set; get; }
        public Node right { set; get; }
        public static List<int> Values { set; get; }
        public static int distance { set; get; }
        public Node(int value) 
        {
            this.Data = value;
            this.left = null;
            this.right = null;
            Values = new List<int>();

        }

        public void AddNode(Node node){
            if(node.Data<this.Data)
            {
                if (this.left is null) this.left = node;
                else this.left.AddNode(node);
            } 
            if(node.Data>this.Data)
            {
                if (this.right is null) this.right = node;
                else this.right.AddNode(node);
            }
        }

       
       

        internal void searchelement(int v)
        {
            if (this.Data == v) Console.WriteLine("Element found");
            else if (this.Data > v&& this.left!=null) this.left.searchelement(v);
            else if (this.Data < v&& this.right!=null) this.right.searchelement(v);
        }

        internal void traverseNode()
        {
            if (this.left != null) this.left.traverseNode();
            //Console.Write(this.Data+" ");
            Values.Add(this.Data);
            if (this.right != null) this.right.traverseNode();


        }
        internal void findDistance(int p1, int p2)
        {
            if (this.Data == p1 && this.right != null) this.right.find(p2);
            else if (this.Data == p2 && this.left != null) this.left.find(p1);
            else if (p1 < this.Data && p2 < this.Data&&this.left!=null) this.left.findDistance(p1, p2);
            else if (p1 > this.Data && p2 > this.Data&&this.right!=null) this.right.findDistance(p1, p2);
            else if (p1 < this.Data && this.Data < p2&&this.left!=null&&this.right!=null)
            {
              //  distance++;
                this.left.find(p1);
              //  distance++;
                this.right.find(p2);
            }

        }

       

        private void find(int p1)
        {
            if (this.Data == p1) distance++;   
            else if (p1 < this.Data && this.left!=null) {
                distance++;
                this.left.find(p1);   
            }
            else if (this.Data<p1&&this.right!=null) {
                distance++;
                this.right.find(p1);   
            }
        }
    }
}
