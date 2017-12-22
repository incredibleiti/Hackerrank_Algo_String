using System;
using System.Linq;

class Solution
{
    static int alternatingCharacters(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length-1; i++)
        {
            if(s[i+1] == s[i])
            {
                count++;
            }
        }
        return count;
    }

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string s = Console.ReadLine();
            int result = alternatingCharacters(s);
            Console.WriteLine(result);
        }
        Console.ReadKey();
    }
}

