using System;
using System.Collections.Generic;
using System.Linq;

class IntFrequency
{
    public void printFrequency(List<int> list)
    {
        if (list == null || list.Count() == 0)
            return;

        for (int i = 0; i < list.Count(); i++)
        {
            if (list[i] > list.Count() || list[i] < 1)
                return;

            list[i] = list[i] - 1;
        }

        for (int i = 0; i < list.Count(); i++)
        {
            list[list[i]%list.Count()] = list[list[i] % list.Count()] + list.Count();
        }

        for (int i = 0; i < list.Count(); i++)
        {
            Console.WriteLine($"{i+1}:{list[i]/list.Count()}");
        }
    }
}