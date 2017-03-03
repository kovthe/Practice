using System;
using System.Collections.Generic;
using System.Linq;

class CountIslands
{
    public int count(char[,] mat)
    {
        if (mat == null)
            return 0;

        int islands = 0, rows = mat.GetLength(0), columns = mat.GetLength(1);


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                char element = mat[i, j];
                if (element == 'X' && (i - 1 < 0 || mat[i - 1, j] == 'O') && (j + 1 >= columns || mat[i, j + 1] == 'O'))
                    islands++;
            }
        }

        return islands;
    }
}