using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    class LinkedListNode
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int d)
        {
            data = d;
            next = null;
        }
    }

    class LinkedList
    {
        public LinkedListNode head;

        public void AddAtEnd(int data)
        {
            if (head == null)
            {
                head = new LinkedListNode(data);
                return;
            }

            LinkedListNode current = head;

            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new LinkedListNode(data);

        }
        public void AddAtBegin(int data)
        {
            LinkedListNode newHeadNode = new LinkedListNode(data);
            if (head == null)
            {
                head = newHeadNode;
                return;
            }
            newHeadNode.next = head;
            head = newHeadNode;
        }
        public void print()
        {
            if (head == null)
            {
                Console.WriteLine("Empty");
                return;
            }
            LinkedListNode current = head;
            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
            Console.WriteLine();

        }
        public void DeleteByData(LinkedListNode node, int Value)
        {
            head = node;
            if (head.data == Value)
            {
                head = head.next;
                print();
                return;
            }
            LinkedListNode current = head;
            while (current.next != null)
            {
                if (current.next.data == Value)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
            print();
        }
        public void DeleteList(LinkedListNode node)
        {
            head = node;
            if (head == null)
            {
                print();
                return;
            }

            LinkedListNode temp, current = head;
            while (current.next != null)
            {
                temp = current.next;
                current.next = null;
                current = temp;
            }
            head = null;
            Console.WriteLine("Entire List Is Deleted");
            print();
        }
        public int CountElements(LinkedListNode node)
        {
            head = node;
            int count = 0;
            LinkedListNode current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }
        public void ReverseWithIteration(LinkedListNode node)
        {
            head = node;
            LinkedListNode current = head, result = null, temp;
            while (current != null)
            {
                temp = current.next;
                current.next = result;
                result = current;
                current = temp;
            }
            head = result;
        }
        public void ReverseWithRecurssion(LinkedListNode head)
        {
            if (head == null) { return; }
            LinkedListNode rest, first;
            first = head;
            rest = first.next;
            if (rest == null)
            {
                return;
            }
            ReverseWithRecurssion(rest);
            first.next.next = first;
            first.next = null;
            head = rest;
            Console.WriteLine("Data:" + rest.data);
            print();
        }
        public void ReverseWithTailRecursion(LinkedListNode head, LinkedListNode prev)
        {

        }
        public bool Search(LinkedListNode head, int key)
        {
            LinkedListNode current = head;
            while (current != null)
            {
                if (current.data == key)
                    return true;
                current = current.next;
            }
            return false;
        }
        /*        public LinkedList Intersection(LinkedListNode head1, LinkedListNode head2)
                {
                    LinkedListNode t1 = head1 , t2 = head2;

                    LinkedListNode newHeadNode;

                    while (t1 != null)
                    {
                        while (t2 != null)
                        {
                            if (t1.data == t2.data)
                            {
                                //newHeadNode = new LinkedListNode(t1.data);

                            }
                            t2 = t2.next;
                        }
                        t1 = t1.next;
                    }
                }*/
        public void DeleteDuplicates(LinkedListNode head)
        {
            LinkedListNode current = head;
            HashSet<int> hs = new HashSet<int>();
            LinkedListNode prev = null;
            while (current != null)
            {
                if (hs.Contains(current.data))
                {
                    prev.next = current.next;
                }
                else
                {
                    hs.Add(current.data);
                    prev = current;
                }
                current = current.next;
            }
            print();
        }
        public LinkedListNode KthElementFromLat(LinkedListNode head, int k)
        {
            if (k == 0) { return null; }
            LinkedListNode current = head;
            LinkedListNode runner = head;

            for (int i = 0; i < k - 1; i++)
            {
                if (runner == null)
                    return null;
                runner = runner.next;
            }
            if (runner == null)
                return null;

            while (runner.next != null)
            {
                current = current.next;
                runner = runner.next;
            }
            return current;
            //if (head == null) { return; }
            //LinkedListNode first, rest;

            //first = head;
            //rest = first.next;
            //if (rest == null) { return; }
            //count++;
            //KthElementFromLat(rest, k,count);

            //if (count == k)
            //{
            //    Console.Write("Kth element from the Last is:" + first.data);
            //    return;
            //}
            //first.next.next = first;
            //first.next = null;

            //rest = head;
        }
    }

    class LinkedListProgram
    {
        static void Main(string[] args)
        {
            LinkedList List1 = new LinkedList();
            LinkedList List2 = new LinkedList();

            LinkedList Lobj = new LinkedList();

            Console.WriteLine("------------------------------------ List1 ------------------------------------------");
            List1.AddAtBegin(30);
            List1.AddAtBegin(25);
            List1.AddAtBegin(20);
            List1.AddAtBegin(15);
            List1.print();
            List1.AddAtEnd(35);
            List1.AddAtEnd(40);
            List1.print();
            List1.DeleteByData(List1.head, 30);
            Console.WriteLine("The Number Of Elements In List1 are: " + List1.CountElements(List1.head));
            List1.ReverseWithIteration(List1.head);
            List1.print();
            List1.ReverseWithRecurssion(List1.head);
            List1.print();
            //Console.WriteLine("-->");
            //            List1.DeleteDuplicates(List1.head);
            Console.WriteLine("Kth element from the Last is:" + List1.KthElementFromLat(List1.head, 2).data);




            Console.WriteLine("------------------------------------ List2 ------------------------------------------");

            List2.AddAtBegin(5);
            List2.AddAtBegin(4);
            List2.AddAtBegin(3);
            List2.AddAtBegin(2);
            List2.print();
            List2.AddAtEnd(6);
            List2.AddAtEnd(7);
            List2.print();
            List2.DeleteList(List2.head);


            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.Read();
        }
    }
}
