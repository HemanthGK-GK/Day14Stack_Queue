using System;
using System.Collections;

namespace UC1StackList
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push(70);
            stk.Push(30);
            stk.Push(56);

            foreach(var i in stk)
            {
                Console.WriteLine(i);
            }
        }
    }
}
