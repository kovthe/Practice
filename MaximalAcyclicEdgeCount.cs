using Puzzles;
using System;
using System.Collections.Generic;
using System.Linq;

class MaximalAcyclicEdgeCount
{
    public int? getCount(Graph g)
    {
        if (g == null || g.nodeInfo.Count == 0)
            return -1;

        List<Node> sortedNodes = new List<Node>();
        if (!TrySortNodes(g, out sortedNodes))
            return -1;

        int countEdges = 0;

        for (int i = 0; i < sortedNodes.Count(); i++)
        {
            int nodesToRight = sortedNodes.Count() - (i + 1);
            countEdges += (nodesToRight - sortedNodes[i].edges.Count());
        }

        return countEdges;
    }

    private bool TrySortNodes(Graph g, out List<Node> sortedNodes)
    {
        throw new NotImplementedException();
    }
}