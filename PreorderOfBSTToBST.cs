using Puzzles.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;

class PreorderOfBSTToBST
{
    public BinaryNode toBST(List<int> preorder)
    {
        if (preorder == null || preorder.Count() == 0)
            return null;

        int size;
        return toBST(preorder, 0, double.NegativeInfinity, double.PositiveInfinity, out size);
    }

    //construct all nodes given preorder root and range
    private BinaryNode toBST(List<int> preorder, int index, double min, double max, out int size)
    {
        size = 0;
        if (preorder == null || preorder.Count() == 0 || index >= preorder.Count() || preorder[index] < min || preorder[index] > max)
            return null;

        size++;
        BinaryNode root = new BinaryNode{ value = preorder[index] };
        int leftSubtreeSize;
        root.left = toBST(preorder, index + 1, min, root.value, out leftSubtreeSize);

        int rightSubtreeSize;
        root.right = toBST(preorder, index + leftSubtreeSize + 1, root.value, max, out rightSubtreeSize);

        size += (leftSubtreeSize + rightSubtreeSize);

        return root;
    }
}