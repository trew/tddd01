using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SprakTest
{
    class Anagram : Test
    {
        public Anagram(string fileName): base(fileName)
        {
           addAnswer("Results are shown as \"word1\" : \"word2\" if the answer was correct or not");
        }

        public override bool Evaluate(string word1, string word2, int value)
        {
            bool isAnagram = checkAnagram(word1, word2) ;
            bool answer;
            // if value is 0 then it indicates false
            answer = (value == 0) ? false : true;
            if (isAnagram == answer)
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

        private bool checkAnagram( string word1, string word2 )
        {
           string lowercase_word1 = word1.ToLower();
           string lowercase_word2 = word2.ToLower();

           char[] a = lowercase_word1.ToCharArray();
           char[] b = lowercase_word2.ToCharArray();
           if (a.Length != b.Length)
           {
              return false;
           }
           Array.Sort(a);
           Array.Sort(b);
           for (int i = 0; i < a.Length; i++)
           {
              if (a[i] == b[i])
              {
                 continue;
              }
              else
              {
                 return false;
              }
           }
           return true;
        }
    }
}
