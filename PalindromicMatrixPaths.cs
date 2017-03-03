using System;
using System.Collections.Generic;
using System.Linq;

class PalindromicMatrixPaths
{
    private IDictionary<string, int> mapping;

    public int countPaths(char[,] mat)
    {
        mapping = new Dictionary<string, int>();
        if (mat == null)
            return 0;

        return countPaths(mat, 0, 0, mat.GetLength(0) - 1, mat.GetLength(1) - 1);
    }

    private int countPaths(char[,] mat, int tlx, int tly, int brx, int bry)
    {
        int rows = mat.GetLength(0);
        int columns = mat.GetLength(1);

        if (tlx < 0 || tlx >= rows || brx < 0 || brx >= rows || tly < 0 || tly >= columns || bry < 0 || bry >= columns
            || tlx>brx || tly>bry)
            return 0;

        if (mat[tlx, tly] != mat[brx, bry])
            return 0;

        if (Math.Abs(tlx-brx)+Math.Abs(tly-bry)<=1)
            return 1;

        int sum = 0;
        string key = $"{tlx},{tly},{brx},{bry}";
        if (mapping.TryGetValue(key, out sum))
            return sum;

        sum = 0;

        sum += countPaths(mat, tlx + 1, tly, brx, bry - 1);
        sum += countPaths(mat, tlx + 1, tly, brx - 1, bry);
        sum += countPaths(mat, tlx, tly + 1, brx, bry - 1);
        sum += countPaths(mat, tlx, tly + 1, brx - 1, bry);

        mapping.Add(key, sum);
        return sum;
    }
}