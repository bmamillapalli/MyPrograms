using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreesEx
{
    class Node
    {
        private int data;
        private Node left, right;

        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
    class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void InsertNode(int item)
        {
            Node newNode = new Node();
            newNode.Data = item;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                while (true)
                {
                    Node parent = current;
                    if (item < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void PreOrder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Data + " ");
                PreOrder(Root.Left);
                PreOrder(Root.Right);
            }
        }
        public void InOrder(Node Root)
        {
            if (Root != null)
            {
                InOrder(Root.Left);
                Console.Write(Root.Data + " ");
                InOrder(Root.Right);
            }
        }
        public void PostOrder(Node Root)
        {
            if (Root != null)
            {
                PostOrder(Root.Left);
                PostOrder(Root.Right);
                Console.Write(Root.Data + " ");
            }
        }
        public void Search(int value)
        {
            if (root != null)
            {
                Node current = root;
                //              Node parent;
                int jj = 0;
                while (current != null)
                {
                    Console.WriteLine("jj: " + (jj++));
                    //                  parent = current;
                    if (current.Data == value)
                    {
                        Console.WriteLine("The element has Been Found");
                        break;
                    }
                    else if (current.Data > value)
                    {
                        current = current.Left;
                    }
                    else if (current.Data < value)
                    {
                        current = current.Right;
                    }
                    else
                    {
                        Console.WriteLine("Element Not Found");
                        break;
                    }
                }
            }

        }
        /*
        public Node Deletion(Node rootNode, int num)
        {
            Node current = root;
            if (current == null)
            {
                return root;
            }
            else if (current.Data < num)
            {
                current.Left = Deletion(current.Left, num);
                return current.Left;
            }
            else if (current.Data > num)
            {
                current.Right = Deletion(current.Right, num);
                return current.Right;
            }
            else
            {
                if ((current.Left == null) && (current.Right == null))
                {
                    Deletion root; 
                }
            }

        }

        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Nobj = new BinaryTree();
            Nobj.InsertNode(5);
            Nobj.InsertNode(3);
            Nobj.InsertNode(7);
            Nobj.InsertNode(2);
            Nobj.InsertNode(4);
            Nobj.InsertNode(6);
            Nobj.InsertNode(8);

            //Nobj.InOrder(Nobj.ReturnRoot());

            bool found = true;
            while (found)
            {
                Console.WriteLine("\nWhat operation You want to perform?");
                Console.WriteLine("1. Insertion");
                Console.WriteLine("2. Traversing");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Exit");
                int sel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (sel)
                {
                    case 1:
                        Console.WriteLine("Enter The Value You Want to Push");
                        int item = Convert.ToInt32(Console.ReadLine());
                        Nobj.InsertNode(item);
                        break;
                    case 2:
                        Console.WriteLine("\nPreOrder Traversing:");
                        Nobj.PreOrder(Nobj.ReturnRoot());
                        Console.WriteLine();
                        Console.WriteLine("\nInOrder Traversing:");
                        Nobj.InOrder(Nobj.ReturnRoot());
                        Console.WriteLine();
                        Console.WriteLine("\nPostOrder Traversing:");
                        Nobj.PostOrder(Nobj.ReturnRoot());

                        break;
                    case 3:
                        Console.WriteLine("Enter The Value You Want to Search");
                        int value = Convert.ToInt32(Console.ReadLine());
                        Nobj.Search(value);
                        break;
                    case 4:
                        found = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.Read();
        }
    }


}
