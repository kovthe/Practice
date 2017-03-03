using Puzzles.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;

class ConvertBSTToHeap
{
    public BinaryNode heapify(BinaryNode root)
    {
        if (root == null || (root.left == null && root.right == null))
            return root;

        BinaryNode sortedRoot = toList(root);
        BinaryNode runner = sortedRoot.right;

        Queue<BinaryNode> q = new Queue<BinaryNode>();
        q.Enqueue(sortedRoot);

        while (runner!=null)
        {
            BinaryNode toBeFilled = q.Dequeue();

            toBeFilled.left = runner;
            q.Enqueue(runner);

            toBeFilled.right = runner.right;
            if (runner.right != null)
                q.Enqueue(runner.right);

            runner = runner?.right?.right;
            toBeFilled.left.right = null;
            if (toBeFilled.right!=null)
                toBeFilled.right.right = null;
        }

        return sortedRoot;
    }

    private BinaryNode toList(BinaryNode root)
    {
        BinaryNode start = null;
        BinaryNode end = null;
        inOrder(root, ref start, ref end);
        return start;
    }

    private void inOrder(BinaryNode root, ref BinaryNode start, ref BinaryNode end)
    {
        if (root == null)
            return;

        inOrder(root.left, ref start, ref end);
        if (end == null)
        {
            end = root;
            start = root;
        }
        else
        {
            end.right = root;
            end = root;
        }
        root.left = null;
        inOrder(root.right, ref start, ref end);
    }
}