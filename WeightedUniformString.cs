using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the weightedUniformStrings function below.
     */
    static string[] weightedUniformStrings(string s, int[] queries) {
       int len = queries.Length;
        string[] res = new string[len];
        List<int> indexlst = new List<int>();
        int cnt = 1;

        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 != s.Length)
            {
                //string substring = string.Empty;
                if (s[i + 1] != s[i])
                {
                    indexlst.Add(char.ToUpper(s[i]) - 64);
                    cnt = 1;
                }
                else
                {
                    cnt++;
                    if (cnt > 1)
                    {
                        indexlst.Add(cnt * (char.ToUpper(s[i]) - 64));
                    }
                }
            }
            else
            {
                indexlst.Add(char.ToUpper(s[i]) - 64);
            }
        }

        for (int i = 0; i < queries.Length; i++)
        {
            if(indexlst.Contains(queries[i]))
            {
                res[i] = "Yes";
            }
            else
            {
                res[i] = "No";
            }
        }

        return res;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int queriesCount = Convert.ToInt32(Console.ReadLine());

        int[] queries = new int [queriesCount];

        for (int queriesItr = 0; queriesItr < queriesCount; queriesItr++) {
            int queriesItem = Convert.ToInt32(Console.ReadLine());
            queries[queriesItr] = queriesItem;
        }

        string[] result = weightedUniformStrings(s, queries);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
