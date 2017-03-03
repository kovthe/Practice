using Puzzles.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;

class LargestAncestorDescendantDifference
{
    public int? largestDifference(BinaryNode root)
    {
        int? min;
        return largestDifference(root, out min);
    }

    private int? largestDifference(BinaryNode root, out int? min)
    {
        min = null;
        if (root == null)
            return null;

        if (root.left == null && root.right == null)
        {
            min = root.value;
            return null;
        }

        int? leftMin, rightMin;
        int? leftMaxDiff = largestDifference(root.left, out leftMin);
        int? rightMaxDiff = largestDifference(root.right, out rightMin);

        int minChild = getMin(leftMin, rightMin).Value;
        min = Math.Min(minChild, root.value);

        return root.value-minChild;
    }

    private int? getMin(int? value1, int? value2)
    {
        if (value1 == null && value2 == null)
            return null;

        if (value1 == null)
            return value2;

        if (value2 == null)
            return value1;

        return Math.Min(value1.Value, value2.Value);
    }
}