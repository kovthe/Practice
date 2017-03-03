using System;
using System.Collections.Generic;
using System.Linq;

class ContiguousOnes
{
    public int getIndex(List<int> list)
    {
        if (list == null || !list.Any())
            return -1;

        int maxIndex = -1, maxLength = 0;

        for (int i = 0; i < list.Count(); i++)
        {
            if (list[i] == 1)
                continue;

            int leftSubarray = 0, rightSubarray = 0;
            for (int j = i - 1; j >= 0; j--)
            {
                if (list[j] == 0)
                    break;

                leftSubarray++;
            }

            for (int j = i + 1; j < list.Count(); j++)
            {
                if (list[j] == 0)
                    break;

                rightSubarray++;
            }

            if (rightSubarray + leftSubarray > maxLength)
            {
                maxIndex = i;
                maxLength = rightSubarray + leftSubarray;
            }
        }

        return maxIndex;
    }
}