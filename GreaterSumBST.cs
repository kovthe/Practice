using Puzzles.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;

class GreaterSumBST
{
    public void transform(BinaryNode root)
    {
        transform(root, 0);
    }

    private void transform(BinaryNode root, int additive)
    {
        if (root == null)
            return;

        if (root.right == null && root.left == null)
        {
            root.value = additive;
            return;
        }

        int prevRootValue = root.value;
        if (root.right != null)
        {
            root.value += root.right.value;
            transform(root.right, additive);
            root.value += root.right.value;
        }

        if (root.left != null)
        {
            transform(root.left, root.value + prevRootValue);
        }
    }
}