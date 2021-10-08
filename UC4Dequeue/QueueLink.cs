using System;
using System.Collections.Generic;
using System.Text;

namespace UC4Dequeue
{
   public class QueueLink
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
        Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;

            }
            Console.WriteLine(node.data + " inserted into queue ");
        }

        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("Value popped is : " + this.head.data);
            this.head = this.head.next;
        }

        public void Print()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;

            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

        }
    }
}
