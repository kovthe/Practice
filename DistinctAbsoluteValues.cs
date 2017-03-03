using System;
using System.Collections.Generic;
using System.Linq;

class DistinctAbsoluteValues
{
    public int distinctValues(List<int> list)
    {
        if (list == null || list.Count() == 0)
            return 0;

        return distinctValues(list, 0, list.Count() - 1);
    }

    private int distinctValues(List<int> list, int left, int right)
    {
        if (left > right)
            return 0;

        if (left == right)
            return 1;

        int absLeft = abs(list[left]), absRight = abs(list[right]);

        while (left + 1 <= right)
        {
            if (list[left + 1] == list[left])
            {
                left++;
                continue;
            }

            break;
        }

        while (right - 1 >= left)
        {
            if (list[right - 1] == list[right])
            {
                right--;
                continue;
            }

            break;
        }

        if (left >= right)
            return 1;
        
        if (absLeft == absRight)
            return distinctValues(list, left + 1, right - 1) + 1;

        if (absRight > absLeft)
            return distinctValues(list, left, right - 1) + 1;

        return distinctValues(list, left + 1, right) + 1;
    }

    private int abs(int x)
    {
        if (x < 0)
            return -x;

        return x;
    }
}