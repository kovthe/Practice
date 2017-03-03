using System;
using System.Collections.Generic;
using System.Linq;
using Practice;

class LoopDetectorAndRemover
{
    public bool removeLoop(Node root)
    {
        if (root == null)
            return false;

        Node slow = root;
        Node fast = root;

        bool loopFound = false;
        while (fast?.Next?.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (fast == slow)
            {
                loopFound = true;
                break;
            }
        }

        if (!loopFound)
            return loopFound;

        int loopLength = 0;
        while (fast.Next != slow)
        {
            loopLength++;
            fast = fast.Next;
        }

        loopLength++;

        slow = root;
        fast = root;

        for (int i = 1; i < loopLength; i++)
        {
            fast = fast.Next;
        }

        while (fast.Next != slow)
        {
            fast = fast.Next;
            slow = slow.Next;
        }

        fast.Next = null;

        return true;
    }
}