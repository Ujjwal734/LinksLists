using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinksLists
{
    public class LinkList
    {
        public Node head;
        public void Add (int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list",node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public Node InsertAtAnyPosition(int position , int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position / Position should not be less than one");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position ==1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position Out of Range...! ");
                }
            }
            Console.WriteLine("{0} inserted into linked list",+ data);
            return head;
        }
        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;
        }
        public Node Search(int Value)
        {
            while (this.head != null)
            {
                if (this.head.data == Value)
                {
                    return this.head;
                }
                this.head=this.head.next;
            }
            return null;
        }
        public void DeleteAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkList is Empty...!");
                return;
            }
            Node temp = this.head;
            if (position ==0)
            {
                this.head = temp.next;
                return;
            }
            for (int i =0; temp != null && i<position-1;i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
        }
        public void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Linklist is empty....! ");
                return;
            }
            while (temp !=null)
            {
                Console.WriteLine(temp.data +" ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length of LinkList is :- " + " " + count);
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
    }
}
