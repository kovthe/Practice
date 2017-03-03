using System;
using System.Collections.Generic;
using System.Linq;

class AlternateElements
{
    public void printAlternate(List<int> l1, List<int> l2)
    {
        if (l1 == null || !l1.Any() || l2 == null || !l2.Any())
            return;

        backtrack(new List<int>(), l1, l2, 0, 0, 0);
    }

    private void backtrack(List<int> partial, List<int> l1, List<int> l2, int i1, int i2, int turn)
	{
		if (turn == 0)
		{
			for (int i = i1; i<l1.Count();i++)
			{
				if (!partial.Any() || l1[i]>partial[partial.Count() - 1])
				{
					partial.Add(l1[i]);
                    backtrack(partial, l1, l2, i+1, i2,1);
                    partial.RemoveAt(partial.Count()-1);
                }		
			}
		}
		else
		{
			for (int i = i2; i<l2.Count();i++)
			{
				if (l2[i]>partial[partial.Count() - 1])
				{
					partial.Add(l2[i]);
					Console.WriteLine(string.Join(",", partial));
                    backtrack(partial, l1, l2, i1, i+1,0);
                    partial.RemoveAt(partial.Count() - 1);
                }
			}
		}
	}
}