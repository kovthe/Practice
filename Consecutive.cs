using System;
using System.Collections.Generic;
using System.Linq;

class Consecutive
{
    public bool areConsecutive(List<int> list)
    {
        if (list == null || !list.Any())
            return false;

        int min = list[0];
        for (int i = 0; i < list.Count(); i++)
            if (list[i] < min)
                min = list[i];

        for (int i = 0; i < list.Count(); i++)
            list[i] = list[i] - min;

        for (int i = 0; i < list.Count(); i++)
        {
            int number = list[i] >= 0 ? list[i] : -list[i];
            int index = number % list.Count();
            if (list[index] < 0)
                return false;

            list[index] = -list[index];
        }

        return !list.Where(x => x > 0).Any();
    }
}