using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        int len = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        //my code
        int temp = 0;
        for (int i = 0; i < len; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                if (s[i] != s[j])
                {
                    bool gfn = true;
                    Stack<char> sta = new Stack<char>();
                    foreach (char c in s)
                    {
                        if (c == s[i] || c == s[j])
                        {
                            sta.Push(c);
                        }
                    }
                    char[] ca = sta.ToArray();
                    for (int k = 0; k < ca.Length - 1; k++)
                    {
                        if (ca[k] != ca[k + 1] && gfn == true)
                        {
                            gfn = true;
                        }
                        else
                        {
                            gfn = false;
                        }
                    }
                    if (gfn == true && ca.Length > temp)
                    {
                        temp = ca.Length;
                    }
                }
            }
        }
        Console.WriteLine(temp);
    }
}

