using Practice;
using System;
using System.Collections.Generic;
using System.Linq;

class ReverseList
{
    public Node getReversedList(Node root)
    {
        if (root == null || root.Next == null)
            return root;

        Node endOfReversedSlice = root.Next;
        Node start = getReversedList(endOfReversedSlice);
        endOfReversedSlice.Next = root;
        root.Next = null;
        return start;
    }
}