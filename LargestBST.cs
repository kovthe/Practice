using Puzzles.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;

class LargestBST
{
    private struct Info
    {
        public int minIfBst;
        public int maxIfBst;
        public int sizeRooted, sizeAny;
        public bool isBST;
    }

    //assume distinct values
    public int largestBSTSize(BinaryNode root)
    {
        return largestBST(root).sizeAny;
    }

    private Info largestBST(BinaryNode root)
    {
        Info info = new Info{ sizeRooted = 0,sizeAny = 0,isBST = false};
        if (root == null)
            return info;


        if (root.left == null && root.right == null)
        {
            info.isBST = true;
            info.sizeRooted = 1;
            info.sizeAny = 1;

            info.minIfBst = root.value;
            info.maxIfBst = root.value;
            return info;
        }

        Info leftSide = largestBST(root.left), rightSide = largestBST(root.right);

        if (root.left != null && root.right == null)
        {
            if (leftSide.isBST && leftSide.maxIfBst < root.value)
            {
                info.isBST = true;
                info.sizeRooted = 1 + leftSide.sizeRooted;
                info.sizeAny = 1 + leftSide.sizeAny;
                info.minIfBst = Math.Min(leftSide.minIfBst, root.value);
                info.maxIfBst = Math.Max(leftSide.maxIfBst, root.value);
            }
            else
            {
                info.sizeAny = leftSide.sizeAny;
            }
        }
        else if (root.left == null && root.right != null)
        {
            if (rightSide.isBST && rightSide.minIfBst > root.value)
            {
                info.isBST = true;
                info.sizeRooted = 1 + rightSide.sizeRooted;
                info.sizeAny = 1 + rightSide.sizeAny;
                info.minIfBst = Math.Min(rightSide.minIfBst, root.value);
                info.maxIfBst = Math.Max(rightSide.maxIfBst, root.value);
            }
            else
            {
                info.sizeAny = rightSide.sizeAny;
            }
        }
        else
        {
            if (leftSide.isBST && rightSide.isBST && leftSide.maxIfBst < root.value && rightSide.minIfBst > root.value)
            {
                info.isBST = true;
                info.sizeRooted = 1 + leftSide.sizeRooted + rightSide.sizeRooted;
                info.sizeAny = 1 + leftSide.sizeAny + rightSide.sizeAny;
                info.minIfBst = Math.Min(leftSide.minIfBst, root.value);
                info.minIfBst = Math.Min(rightSide.minIfBst, info.minIfBst);
                info.maxIfBst = Math.Max(leftSide.maxIfBst, root.value);
                info.maxIfBst = Math.Max(rightSide.maxIfBst, info.maxIfBst);
            }
            else
            {
                info.sizeAny = Math.Max(rightSide.sizeAny, leftSide.sizeAny);
            }
        }

        return info;
    }
}