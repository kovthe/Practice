using System;
using System.Collections.Generic;
using System.Linq;

class kLengthShortestPath
{
    public int? getKLengthShortestPath(int?[,] adj, int s, int t, int k)
    {
        if (adj == null || k <= 0)
            return null;

        int rows = adj.GetLength(0);
        int columns = adj.GetLength(1);

        if (rows != columns || s < 0 || s >= rows || t < 0 || t >= columns)
            return null;

        //can actually get away with a couple of 2D matrices
        int?[,,] dp = new int?[rows, columns, k+1];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                dp[i, j, 1] = adj[i, j];
            }
        }

        for (int length = 2; length <= k; length++)
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    for (int neighbour = 0; neighbour < columns; neighbour++)
                    {
                        if (adj[i, neighbour] == null || dp[neighbour, j, length - 1] == null)
                            continue;

                        if (dp[i, j, length] == null || dp[i, j, length] > adj[i, neighbour] + dp[neighbour, j, length - 1])
                            dp[i, j, length] = adj[i, neighbour] + dp[neighbour, j, length - 1];
                    }
                }

        return dp[s, t, k];
    }
}