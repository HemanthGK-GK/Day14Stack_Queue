using System;

namespace UC3QueueInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueLink link = new QueueLink();
            link.Enqueue(56);
            link.Enqueue(30);
            link.Enqueue(70);
        }
    }
}
