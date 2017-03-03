using System;
using System.Collections.Generic;
using System.Linq;

class CommonElementsInSortedArrays
{
    public void printCommonElements(List<int> list1, List<int> list2, List<int> list3)
    {
        if (list1 == null || !list1.Any() || list2 == null || !list2.Any() || list3 == null || !list3.Any())
            return;

        printCommonElements(list1, list2, list3, 0, 0, 0);
    }

    private void printCommonElements(List<int> list1, List<int> list2, List<int> list3, int i1, int i2, int i3)
    {
        if (i1 >= list1.Count() || i2 >= list2.Count() || i3 >= list3.Count())
            return;

        if (list1[i1] == list2[i2] && list2[i2] == list3[i3])
        {
            Console.WriteLine(list1[i1]);
            printCommonElements(list1, list2, list3, i1 + 1, i2 + 1, i3 + 1);
            return;
        }

        if (list2[i2] <= list1[i1] && list2[i2] <= list3[i3])
        {
            ++i2;
        }
        else if (list3[i3] <= list2[i2] && list3[i3] <= list1[i1])
        {
            ++i3;
        }
        else
        {
            ++i1;
        }

        printCommonElements(list1, list2, list3, i1, i2, i3);
    }
}