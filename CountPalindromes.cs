using System;
using System.Collections.Generic;
using System.Linq;

class CountPalindromes
{
    public int count(string str)
    {
        if (string.IsNullOrWhiteSpace(str) || str.Length < 2)
            return 0;

        bool[,] isPalindrome = new bool[str.Length, str.Length];
        int[,] count= new int[str.Length, str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            isPalindrome[i, i] = true;
            count[i, i] = 0;
        }

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1])
            {
                isPalindrome[i, i + 1] = true;
                count[i, i + 1] = 1;
            }
            else
            {
                isPalindrome[i, i + 1] = false;
                count[i, i + 1] = 0;
            }
        }

        for (int length = 3; length <= str.Length; length++)
        {
            for (int i = 0; i <= str.Length - length; i++)
            {
                if (str[i] == str[i + length - 1])
                    isPalindrome[i, i + length - 1] = isPalindrome[i + 1, i + length - 2];
                else
                    isPalindrome[i, i + length - 1] = false;
            }
        }

        for (int length = 3; length <= str.Length; length++)
        {
            for (int i = 0; i <= str.Length - length; i++)
            {
                int sum = 0;
                if (isPalindrome[i, i + length - 1])
                    sum++;

                count[i, i + length - 1] = sum + count[i, i + length - 2] + count[i + 1, i + length - 1] - count[i + 1, i + length - 2];
            }
        }

        return count[0, str.Length - 1];
    }
}