using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        StringBuilder st = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                int num = (int)c + k;
                if (char.IsLower(c))
                {
                    if (num > 122)
                    {
                        while(num > 122)
                        {
                            num = Math.Abs(122 - num);
                            num = 96 + num;
                        }
                    }
                }
                else
                {
                    if (num > 90)
                    {
                        while (num > 90)
                        {
                            num = Math.Abs(90 - num);
                            num = 64 + num;
                        }
                    }
                }
                st.Append((char)(num));
            }
            else
            {
                st.Append(c);
            }
        }

        Console.WriteLine(st.ToString());
        Console.ReadKey();
    }
}

