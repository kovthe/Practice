using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

class NextGreaterElement
{
    public List<int> getNGE(List<int> list)
    {
        if (list == null || !list.Any())
            return new List<int>();

        List<int> nge = new List<int>(list);
        Stack<int> stack = new Stack<int>();
        stack.Push(-1);
        for (int i = list.Count() - 1; i >= 0; i--)
        {
            while (stack.Any())
            {
                int top = stack.Peek();
                if (top == -1)
                {
                    nge[i] = -1;
                    stack.Push(list[i]);
                    break;
                }

                if (top >= list[i])
                {
                    nge[i] = top;
                    stack.Push(list[i]);
                    break;
                }

                stack.Pop();
            }
        }

        return nge;
    }
}