using System;
using System.Collections.Generic;
using System.Linq;

class CountNegativesInSortedMatrix
{
    public int count(int[,] mat)
    {
        if (mat == null)
            return 0;

        return count(mat, 0, mat.GetLength(1) - 1);
    }

    private int count(int[,] mat, int x, int y)
    {
        if (x >= mat.GetLength(0) || y < 0)
            return 0;

        if (mat[x, y] >= 0)
            return count(mat, x, y - 1);
        else
            return y + 1 + count(mat, x + 1, y);
    }
}