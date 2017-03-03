using System;
using System.Collections.Generic;
using System.Linq;

class AlternatePositiveNegative
{
    public void print(List<int> list)
    {
        if (list == null || list.Count() <= 1)
            return;

        int left = 0, right = list.Count() - 1;
        while (left < right)
        {
            while (left < list.Count())
            {
                if (list[left] < 0)
                    break;

                left++;
            }

            while (right >= 0)
            {
                if (list[right] >= 0)
                    break;

                right--;
            }

            if (right <= left)
                break;

            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }

        int negativeIndex = -1, positiveIndex = -1;

        if (list[1] >= 0)
            positiveIndex = 1;

        for (int i = list.Count() - 1; i >= 0; i--)
        {
            if (list[i] >= 0)
                break;

            negativeIndex = i;
        }

        if (positiveIndex < 0 || negativeIndex < 0)
        {
            Console.WriteLine(string.Join(",", list));
            return;
        }

        for (int i = positiveIndex, j = negativeIndex; i < negativeIndex; i = i + 2)
        {
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;

            if (j + 1 >= list.Count())
                break;

            j++;
        }

        Console.WriteLine(string.Join(",", list));
    }
}