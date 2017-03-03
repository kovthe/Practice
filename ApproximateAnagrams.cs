using System;
using System.Collections.Generic;
using System.Linq;

class ApproximateAnagrams
{
    public int countMinCharsToRemove(string str1, string str2)
    {
        if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
            return -1;

        int[] freq1 = getFrequencyArray(str1);
        int[] freq2 = getFrequencyArray(str2);

        int count = 0;
        for (int i = 0; i < freq1.Length; i++)
        {
            count += Math.Abs(freq1[i] - freq2[i]);
        }

        if (count == (str1.Length + str2.Length))
            return -1;

        return count;
    }

    private int[] getFrequencyArray(string str)
    {
        int[] freq = new int[char.MaxValue];

        for (int i = 0; i < freq.Length; i++)
            freq[i] = 0;

        for (int i = 0; i < str.Length; i++)
        {
            freq[str[i]] = freq[str[i]] + 1;
        }

        return freq;
    }
}