using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SprakTest
{
   class Levenshtein : Test
   {
      public Levenshtein( string fileName ): base(fileName)
      {
      }

      public override bool Evaluate(string word1, string word2, int value)
      {
         int result = calcLeven(word1, word2);
         if (value == result)
         {
            addAnswer(word1 + " : " + word2 + " Correct");
            return true;
         }
         else
         {
            addAnswer(word1 + " : " + word2 + " Wrong");
            return false;
         }
      }

      private int calcLeven( string s, string t )
      {
         int n = s.Length;
         int m = t.Length;
         int[,] d = new int[n + 1, m + 1];

         if (n == 0)
         {
            return m;
         }

         if (m == 0)
         {
            return n;
         }

         for (int i = 0; i <= n; d[i, 0] = i++)
         {

         }

         for (int j = 0; j <= m; d[0, j] = j++)
         {
         }

         for (int i = 1; i <= n; i++)
         {
            for (int j = 1; j <= m; j++)
            {
               int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
               d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + cost);
            }
         }
         return d[n, m];
      }
   }
}
