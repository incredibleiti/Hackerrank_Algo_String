using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int anagaram(string s){
        int[] a = new int[26]; int[] b = new int[26];
        if (s.Length % 2 != 0)
            return -1;
        for (int i = 0, j = s.Length / 2; i < s.Length / 2; i++, j++)
        {
            a[s[i] - 'a']++;
            b[s[j] - 'a']++;
        }
        int diff = 0;
        for (int i = 0; i < 26; i++)
            if (b[i] - a[i] > 0)
                diff += (b[i] - a[i]);
        return diff;
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int result = anagaram(s);
            Console.WriteLine(result);
        }
    }
}
