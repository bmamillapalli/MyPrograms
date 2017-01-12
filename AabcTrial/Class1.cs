using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AabcTrial
{
    // Java program to find union and intersection of two unsorted 
    // linked lists

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
        public LinkedListNode head; // head of list

        /* Linked list Node*/
        /* Function to get Union of 2 Linked Lists */
        public void getUnion(LinkedListNode head1, LinkedListNode head2)
        {
            LinkedListNode t1 = head1, t2 = head2;

            //insert all elements of list1 in the result
            while (t1 != null)
            {
                push(t1.data);
                t1 = t1.next;
            }

            // insert those elements of list2 that are not present
            while (t2 != null)
            {
                if (!isPresent(head, t2.data))
                    push(t2.data);
                t2 = t2.next;
            }
        }
        public void getIntersection(LinkedListNode head1, LinkedListNode head2)
        {
;
            LinkedListNode t1 = head1;

            // Traverse list1 and search each element of it in list2.
            // If the element is present in list 2, then insert the
            // element to result
            while (t1 != null)
            {
                if (isPresent(head2, t1.data))
                    push(t1.data);
                t1 = t1.next;
            }
        }
        /* Utility function to print list */
        public void printList()
        {
            LinkedListNode temp = head;
            while (temp != null)
            {
               Console.Write(temp.data + " ");
                temp = temp.next;
            }
           Console.WriteLine();
        }
          /* Inserts a node at start of linked list */
        public void push(int new_data)
        {
            /* 1 & 2: Allocate the Node &
                    Put in the data*/
            LinkedListNode new_node = new LinkedListNode(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }
        /* A utilty function that returns true if data is present
        in linked list else return false */
        public bool isPresent(LinkedListNode head, int data)
        {
            LinkedListNode t = head;
            while (t != null)
            {
                if (t.data == data)
                    return true;
                t = t.next;
            }
            return false;
        }
    }
   
    class MainFunc
    {
        /* Drier program to test above functions */
        public static void main(string[] args)
        {
            LinkedList llist1 = new LinkedList();
            LinkedList llist2 = new LinkedList();
            LinkedList unin = new LinkedList();
            LinkedList intersecn = new LinkedList();

            /*create a linked lits 10->15->5->20 */
            llist1.push(20);
            llist1.push(4);
            llist1.push(15);
            llist1.push(10);

            /*create a linked lits 8->4->2->10 */
            llist2.push(10);
            llist2.push(2);
            llist2.push(4);
            llist2.push(8);

            intersecn.getIntersection(llist1.head, llist2.head);
            unin.getUnion(llist1.head, llist2.head);

           Console.WriteLine("First List is");
            llist1.printList();

           Console.WriteLine("Second List is");
            llist2.printList();

           Console.WriteLine("Intersection List is");
            intersecn.printList();

           Console.WriteLine("Union List is");
            unin.printList();
        }
    }
}
