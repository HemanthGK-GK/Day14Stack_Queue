using System;

namespace UC4Dequeue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueLink link = new QueueLink();
            link.Enqueue(56);
            link.Enqueue(30);
            link.Enqueue(70);
            link.Print();
            link.Dequeue();
            link.Dequeue();
            link.Print();

        }
    }
}
