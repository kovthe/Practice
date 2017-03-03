using System;
using System.Collections.Generic;
using System.Linq;

class CombinationOf4Sum
{
    public void print(List<int> list, int target)
    {
        if (list == null || list.Count() < 4)
            return;

        list = list.OrderBy(x => x).ToList();

        for (int leftEdge = 0; leftEdge <= list.Count() - 4; leftEdge++)
        {
            for (int rightEdge = list.Count()-1; rightEdge >= leftEdge + 3; rightEdge--)
            {
                findAndPrint(list, leftEdge + 1, rightEdge - 1, target - list[leftEdge] - list[rightEdge], leftEdge, rightEdge);
            }
        }
    }

    private void findAndPrint(List<int> list, int left, int right, int target, int leftEdge, int rightEdge)
    {
        while (left < right)
        {
            if ((list[left] + list[right] == target))
            {
                Console.WriteLine($"{list[leftEdge]},{list[left]},{list[right]},{list[rightEdge]}");
                left++;
                right--;
                continue;
            }

            int currentSum = list[right] + list[left];
            if (currentSum < target)
                left++;
            else
                right--;
        }
    }
}