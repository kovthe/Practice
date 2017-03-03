using Puzzles.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;

class SortedArrayToBalancedBST
{
    public BinaryNode toBalancedBST(List<int> sortedList)
    {
        if (sortedList == null || sortedList.Count() == 0)
            return null;

        return toBalancedBST(sortedList, 0, sortedList.Count() - 1);
    }

    private BinaryNode toBalancedBST(List<int> sortedList, int start, int end)
    {
        if (sortedList == null || sortedList.Count() == 0 || start < 0 || start >= sortedList.Count() || end < 0 || end >= sortedList.Count() || start > end)
            return null;

        int centre = (start + end) / 2;
        BinaryNode root = new BinaryNode { value = sortedList[centre] };
        root.left = toBalancedBST(sortedList, start, centre - 1);
        root.right = toBalancedBST(sortedList, centre + 1, end);

        return root;
    }
}