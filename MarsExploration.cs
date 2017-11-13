using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        string main = "SOS";
        int loop = S.Length / 3;
        int index = 0;
        int cnt = 0;
        for (int i = 0; i < loop; i++)
        {
            string sub = S.Substring(index, 3);
            if(!sub.Equals(main))
            {
                for (int j = 0; j < sub.Length; j++)
                {
                    if(sub[j] != main[j])
                    {
                        cnt += 1;
                    }
                }
            }
            index = index + 3;
        }
      
        Console.WriteLine(cnt);
        Console.ReadKey();
    }
}

