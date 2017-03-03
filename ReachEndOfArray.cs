using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

class ReachEndOfArray
{
    private class Node
    {
        public int id;
        public int distance;
    }

    public int? countSteps(List<int> list)
    {
        if (list == null || !list.Any() || list.Any(x => x < 0 || x > 9))
            return null;

        List<List<int>> valueToIndex = new List<List<int>>();
        for (int i = 0; i < 10; i++)
            valueToIndex.Add(new List<int>());

        for (int i = 0; i < list.Count(); i++)
            valueToIndex[list[i]].Add(i);

        BitArray visited = new BitArray(new int[] { 0 });
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(new Node { id = 0, distance = 0 });
        visited[0] = true;
        while (q.Any())
        {
            Node node = q.Dequeue();
            if (node.id == list.Count() - 1)
                return node.distance;

            List<int> neighbours = new List<int> { node.id - 1, node.id + 1 };
            neighbours.AddRange(valueToIndex[list[node.id]]);

            foreach (int neighbour in neighbours)
            {
                if (isValidIndex(neighbour,list) && !visited[neighbour])
                {
                    visited[neighbour] = true;
                    q.Enqueue(new Node { id = neighbour, distance = node.distance + 1 });
                }
            }
        }

        return -1;
    }

    private bool isValidIndex(int x, List<int> list)
    {
        return x >= 0 && x < list.Count();
    }
}