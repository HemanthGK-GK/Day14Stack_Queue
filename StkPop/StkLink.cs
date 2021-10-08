using System;
using System.Collections.Generic;
using System.Text;

namespace StkPop
{
    class StkLink
    {
        internal class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        private Node top;
        public StkLink()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }

        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Value popped is : "+ this.top.data);
            this.top = this.top.next;
        }

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Top of the stack : "+this.top.data);
        }
        public void ChkEmpty()
        {
            while (this.top != null)
            {
                Pop();
            }
            
        }
    }
}
