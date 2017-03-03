//using System;
//using System.Collections;
//using System.Collections.Generic;

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Hello World");
//        Console.ReadLine();
//    }
//}

//class MinReverseEdges
//{
//    public int MinReverseEdges(Graph graph, int source, int target)
//    {
//        Node s, t;
//        if (graph == null || !graph.nodeInfo.TryGetValue(source, out s) || !graph.nodeInfo.TryGetValue(target, out t))
//            return -1;

//        TransformGraph(graph);
//        PriorityQueue<Node> q = new PriorityQueue<Node>();
//        s.distance = 0;
//        q.Enqueue(s);
//        while (q.Any())
//        {
//            Node nodeToProcess = q.deleteMin();
//            nodeToProcess.color = NodeColor.white;
//            foreach (Edge edge in nodeToProcess.Edges)
//            {
//                Node neighbour = edge.Node;
//                if (neighborur.color == NodeColor.white)
//                    continue;

//                if (neighbour.distance > nodeToProcess.distance + edge.weight)
//                    neighbour.distance = nodeToProcess.distance + edge.weight)
//			}
//        }

//        if (neighbour.distance == double.PositiveInfinity)
//            return -1;

//        return neighbour.distance;
//    }
//}