using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    static string gameOfThrones(string s)
    {
        string result = "NO";
        char[] arr = new char[26];
        
        for (int i = 0; i < s.Length; i++)
        {
            arr[s[i] - 'a']++;
        }

        int cnt = arr.Select(x => x).Where(y => y % 2 != 0).Count();
        if (s.Length % 2 == 0 && cnt == 0) //even string so count of each character should be even
        {
            result = "YES";
        }
        else if (s.Length % 2 != 0 && cnt == 1)// odd then count of each character should be even and one odd count
        {
            result = "YES";
        }
        return result;
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = gameOfThrones(s);
        Console.WriteLine(result);
    }
}

