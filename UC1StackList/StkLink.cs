﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UC1StackList
{
    class StkLink
    {  private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        public void push(int value)
        {
             Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);

        }

    }
}
