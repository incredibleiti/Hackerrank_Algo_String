using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string super_reduced_string(string s){
        // Complete this function
         for (int i = 1; i < s.Length; i++)
        {
            if ((s[i] == s[i - 1]))
            {
                s = s.Substring(0, i - 1) + s.Substring(i + 1);
                i = 0;
            }
        }
        return s;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        if (result.Equals(string.Empty))
        {
            Console.WriteLine("Empty String");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}
