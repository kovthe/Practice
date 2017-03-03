using System;

namespace Practice
{
    class Node
    {
        public int data;
        public Node Next;

        public void print()
        {
            Console.WriteLine(data);

            Node itr = Next;
            while(itr != null)
            {
                Console.WriteLine(itr.data);
                itr = itr.Next;
            }
        }
    }
}
