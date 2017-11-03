using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
         int cnt = 0;
        if(s.Length!=0)
        {
            cnt++;

            for (int i = 0; i < s.Length; i++)
            {
                if(char.IsUpper(s[i]))
                {
                    cnt++;
                }

            }
        }

        Console.WriteLine(cnt);
    }
}
