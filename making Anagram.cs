using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int makingAnagrams(string s1, string s2){
        int[] chars = new int[26];
        foreach (char c1 in s1.ToCharArray()) { chars[c1 - 97]++; }
        foreach (char c2 in s2.ToCharArray()) { chars[c2 - 97]--; }
        int count = 0;
        foreach (int i in chars) { count += Math.Abs(i); }

        return count;
    }

    static void Main(String[] args) {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int result = makingAnagrams(s1, s2);
        Console.WriteLine(result);
    }
}
