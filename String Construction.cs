using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Solution
{
    static int stringConstruction(string s)
    {
        int cnt = 0;
       if(s!=string.Empty)
        {
            cnt = new String(s.Distinct().ToArray()).Length;
        }
        return cnt;
    }

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string s = Console.ReadLine();
            int result = stringConstruction(s);
            Console.WriteLine(result);
        }
    }
}

