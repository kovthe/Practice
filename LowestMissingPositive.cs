using System;
using System.Collections.Generic;
using System.Linq;

class LowestMissingPositive
{
    public void print(List<int> list)
    {
        if (list == null || list.Count() == 0)
            return;

        if (list.Count() == 1)
        {
            if (list[0] == 1)
                Console.WriteLine("2");
            else
                Console.WriteLine("1");

            return;
        }

        int left = 0, right = list.Count() - 1;
        while (left < right)
        {
            while (left < list.Count() && list[left] > 0)
                left++;

            while (right >= 0 && list[right] <= 0)
                right--;

            if (left < right)
            {
                int temp = list[left];
                list[left] = list[right];
                list[right] = temp;
            }
            else
                break;
        }

        if (list[0]<=0)
        {
            Console.WriteLine(1);
            return;
        }

        int rightEdge = 0;
        while ((rightEdge + 1) < list.Count() && list[rightEdge + 1] > 0)
            rightEdge++;

        for (int i = 0; i <= rightEdge; i++)
        {
            int index = (list[i] > 0 ? list[i] : -list[i]) - 1;
            if (index > rightEdge)
                continue;

            if (list[index]>0)
                list[index] = -list[index];
        }

        bool found = false;
        for (int i = 0; i <= rightEdge; i++)
        {
            if (list[i] < 0)
                continue;

            found = true;
            Console.WriteLine(i + 1);
            break;
        }

        if (!found)
            Console.WriteLine(rightEdge + 1);
    }
}