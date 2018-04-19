using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Solution
{
    static int minimumNumber(int n, string password)
    {
        int i = 0;
        string specialch = "!@#$%^&*()-+";


        if (!password.Any(c => char.IsDigit(c)))
        {
            i++;
        }
        if (!password.Any(c => char.IsLower(c)))
        {
            i++;
        }
        if (!password.Any(c => char.IsUpper(c)))
        {
            i++;
        }
        if (password.Intersect(specialch).Count() == 0)
        {
            i++;
        }

        return Math.Max(i, 6 - n);
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string password = Console.ReadLine();
        int answer = minimumNumber(n, password);
        Console.WriteLine(answer);
        Console.ReadKey();
    }
}

