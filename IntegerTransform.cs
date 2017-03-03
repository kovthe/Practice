using System;
using System.Collections.Generic;
using System.Linq;

class IntegerTransform
{
    private class Node
    {
        public int id;
        public int distance;
    }

    private bool verifyRange(int x)
    {
        return x >= 1 && x <= 10000;
    }

    public int countOperations(int x, int y)
    {
        if (!verifyRange(x) || !verifyRange(y))
            return -1;

        HashSet<int> visited = new HashSet<int>();
        Queue<Node> q = new Queue<Node>();

        visited.Add(x);
        q.Enqueue(new Node { id = x, distance = 0 });

        while (q.Any())
        {
            Node node = q.Dequeue();
            if (node.id == y)
                return node.distance;

            int decremented = node.id - 1;
            int doubled = node.id * 2;
            if (!visited.Contains(decremented) && decremented > 1)
            {
                visited.Add(decremented);
                q.Enqueue(new Node { id = decremented, distance = node.distance + 1 });
            }

            if (!visited.Contains(doubled) && doubled > 1)
            {
                visited.Add(doubled);
                q.Enqueue(new Node { id = doubled, distance = node.distance + 1 });
            }
        }

        return -1;
    }
}
