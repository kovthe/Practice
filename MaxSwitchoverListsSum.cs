using Practice;
using System;
using System.Collections.Generic;
using System.Linq;

class MaxSwitchoverListsSum
{
    public int? getSum(Node root1, Node root2)
    {
        if (root1 == null || root2 == null)
            return null;

        int sum1 = 0, sum2 = 0;
        Node i1 = root1, i2 = root2;

        while (i1 != null && i2 != null && i1.data != i2.data)
        {
            int val1 = i1.data;
            int val2 = i2.data;
            if (val1 > val2)
            {
                sum1 += val1;
                i1 = i1.Next;
            }
            else
            {
                sum2 += val2;
                i2 = i2.Next;
            }
        }

        if (i1 != null && i2 != null)
        {
            if (sum1 >= sum2)
                return sum1 + getSum(i1.Next, i2.Next);
            else
                return sum2 + getSum(i1.Next, i2.Next);
        }

        if (i1 == null)
        {
            while (i2 != null)
            {
                sum2 += i2.data;
                i2 = i2.Next;
            }
        }
        else
        {
            while (i1 != null)
            {
                sum1 += i1.data;
                i1 = i1.Next;
            }
        }

        return Math.Max(sum1, sum2);
    }
}