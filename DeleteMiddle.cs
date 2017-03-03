using System;
using System.Collections.Generic;
using System.Linq;
using Practice;

class DeleteMiddle
{
    public Node deleteMiddle(Node root)
    {
        if (root == null || root.Next == null)
            return null;

        if (root.Next.Next == null)
        {
            root.Next = null;
            return root;
        }

        Node slowPrevious = null;
        Node slow = root;
        Node fast = root;

        while (fast?.Next?.Next != null)
        {
            slowPrevious = slow;
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        //Odd case
        if (fast.Next == null)
        {
            slowPrevious.Next = slow.Next;
            slow.Next = null;
        }
        //Even case
        else
        {
            Node deletedNode = slow.Next;
            slow.Next = deletedNode.Next;
            deletedNode.Next = null;
        }

        return root;
    }
}