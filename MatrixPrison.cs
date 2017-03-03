using System;
using System.Collections.Generic;
using System.Linq;

class MatrixPrison
{
    private class Node
    {
        public int x, y;
    }

    public void printOutput(char[,] input)
    {
        if (input == null)
            return;

        //VerifyInput();

        int rows = input.GetLength(0), columns = input.GetLength(1);
        int[,] output = new int[rows, columns];
        bool[,] visited = new bool[rows, columns];
        Queue<Node> q = new Queue<Node>();

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            {
                if (input[i, j] == 'G')
                {
                    q.Enqueue(new Node { x = i, y = j });
                    output[i, j] = 0;
                }
                else if (input[i, j] == 'W')
                    output[i, j] = -1;

                visited[i, j] = false;
            }


        while (q.Any())
        {
            Node node = q.Dequeue();
            List<Node> neighbours = new List<Node> { new Node { x = node.x - 1, y = node.y }, new Node { x = node.x, y = node.y + 1 }, new Node { x = node.x + 1, y = node.y }, new Node { x = node.x, y = node.y - 1 } };
            foreach (Node n in neighbours)
            {
                if (n.x >= 0 && n.x < rows && n.y >= 0 && n.y < columns && input[n.x,n.y]=='O'&&!visited[n.x, n.y])
                {
                    visited[n.x, n.y] = true;
                    output[n.x, n.y] = output[node.x, node.y] + 1;
                    q.Enqueue(n);
                }
            }
        }

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            {
                Console.Write(output[i, j] + ",");
                if (j == columns - 1)
                    Console.WriteLine("");
            }
    }
}