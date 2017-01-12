using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTraversalsWithoutRecursion
{
    class Node
    {
        public int data;
        public Node left, right;

        public Node(int i)
        {
            data = i;
            left = right = null;
        }
    }
    class BinaryTree
    {
        public Node root;
        public void Addright(int x)
        {
            Node newnode = new Node(x);
            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Node current = root;
                Node parent = current;

                current = parent.left;
                if(current == null)
                {
                    parent.left = newnode;
                }
            }
        }
        public void AddLeft(int y)
        {
            Node newnode = new Node(y);

            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Node current = root;
                Node parent = current;

                current = parent.right;
                if (current == null)
                {
                    root = newnode;
                }
            }

        }
        public void InorderTraversal()
        {
            Stack<Node> stk = new Stack<Node>();

            if (root == null)
            {
                return;
            }
            Node currentNode = root;

            while (currentNode != null)
            {
                stk.Push(currentNode);
                currentNode = currentNode.left;
            }

            while (stk.Count > 0)
            {
                currentNode = stk.Pop();
                Console.Write(currentNode.data + " ");

                if (currentNode.right != null)
                {
                    currentNode = currentNode.right;

                    while (currentNode != null)
                    {
                        stk.Push(currentNode);
                        currentNode = currentNode.left;
                    }
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);

            //tree.root.left = new Node(2);
            tree.AddLeft(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);

            tree.InorderTraversal();

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.Read();
        }
    }
}