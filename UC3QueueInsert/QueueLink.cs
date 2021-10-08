using System;
using System.Collections.Generic;
using System.Text;

namespace UC3QueueInsert
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
            Console.WriteLine(node.data+" inserted into queue " );
        }
    }
}
