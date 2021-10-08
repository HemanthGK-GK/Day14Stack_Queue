using System;

namespace StkPop
{
    class Program
    {
        static void Main(string[] args)
        {
            StkLink stk = new StkLink();
            stk.Push(70);
            stk.Push(30);
            stk.Push(56);

            stk.Peek();
            stk.Pop();
            stk.ChkEmpty();
        }
    }
}
