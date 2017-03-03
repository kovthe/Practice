using System;
using System.Collections.Generic;
using System.Linq;

class SortedTriplet
{
    public void PrintSortedTriplet(List<int> list)
    {
        if (list == null || list.Count() < 3)
            return;

        List<int> suffixMax = new List<int>(list);
        for (int i = suffixMax.Count() - 2; i >= 0; i--)
        {
            if (suffixMax[i] < suffixMax[i + 1])
                suffixMax[i] = suffixMax[i + 1];
        }

        int minIndex = 0;
        bool found = false;
        int mid;
        for (mid = 1; mid < list.Count() - 1; mid++)
        {
            if (list[mid] > list[minIndex] && list[mid] < suffixMax[mid + 1])
            {
                found = true;
                break;
            }

            if (list[mid] < list[minIndex])
                minIndex = mid;
        }

        if (found)
            Console.WriteLine($"{list[minIndex]},{list[mid]},{suffixMax[mid + 1]}");
    }
}