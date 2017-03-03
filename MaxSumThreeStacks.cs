using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MaxSumThreeStacks
{
    public int? maxSum(List<int> a1, List<int> a2, List<int> a3)
    {
        if (a1 == null || !a1.Any() || a2 == null || !a2.Any() || a3 == null || !a3.Any())
            return null;

        return maxSum(a1, a2, a3, 0, 0, 0, a1.Sum(x => x), a2.Sum(x => x), a3.Sum(x => x));
    }

    private int? maxSum(List<int> a1, List<int> a2, List<int> a3, int i1, int i2, int i3, int s1, int s2, int s3)
    {
        if (s1 == s2 && s2 == s3)
            return s1;

        int maxIndicator = 0;
        if (s2 > s1)
            maxIndicator = 1;
        else if (s3 > s1)
            maxIndicator = 2;

        if (maxIndicator == 0)
        {
            if (i1 + 1 >= a1.Count())
                return null;

            s1 = s1 - a1[i1];
            i1++;
        }
        else if (maxIndicator == 1)
        {
            if (i2 + 1 >= a2.Count())
                return null;

            s2 = s2 - a2[i2];
            i2++;
        }
        else
        {
            if (i3 + 1 >= a3.Count())
                return null;

            s3 = s3 - a3[i3];
            i3++;
        }

        return maxSum(a1, a2, a3, i1, i2, i3, s1, s2, s3);
    }
}
