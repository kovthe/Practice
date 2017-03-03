using System;
using System.Collections.Generic;
using System.Linq;

class MaxWeightMatrixPath
{
    public int? getMax(int[,] mat)
    {
        if (mat == null)
            return null;

        int rows = mat.GetLength(0), columns = mat.GetLength(1);

        for (int i = rows - 2; i >= 0; i--)
        {
            for (int j = columns - 1; j >= 0; j--)
            {
                if (j == columns - 1)
                {
                    mat[i, j] = mat[i, j] + mat[i + 1, j];
                    continue;
                }

                mat[i, j] = Math.Max(mat[i, j] + mat[i + 1, j], mat[i, j] + mat[i + 1, j + 1]);
            }
        }

        return mat[0, 0];
    }
}