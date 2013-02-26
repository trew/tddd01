using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SprakTest
{
    class Anagram : ITest
    {
        private List<KeyValuePair<string, string>> wordPairs;
        //private Dictionary<string, string> wordPairs;

        public Anagram(string fileName)
        {
            wordPairs = new List<KeyValuePair<string, string>>();
            LoadWords(fileName);
        }

        public void LoadWords(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string wordPair in lines.ToList().GetRange(1, lines.Length-1))
            {
                Console.WriteLine("Adding " + wordPair);
                string[] words = wordPair.Split(':');
                wordPairs.Insert(wordPairs.Count, new KeyValuePair<string, string>(words[0], words[1]));
                
            }

            foreach (KeyValuePair<string, string> kvp in wordPairs)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }

        public bool Evaluate(string word1, string word2, int value)
        {
            bool isAnagram = checkAnagram(word1, word2) ;
            bool answer;
            answer = (value == 0) ? false : true;
            if (isAnagram == answer)
            {
               return true;
            }
            else
            {
               return false;
            }
        }
        public KeyValuePair<string, string> GetNextPair()
        {
            if (wordPairs.Count != 0)
            {
                KeyValuePair<string, string> firstPair = wordPairs.First();
                wordPairs.RemoveAt(0);
                return firstPair;
            }
            else
            {
                return new KeyValuePair<string,string>("","");
            }
        }
        private Boolean checkAnagram( string word1, string word2 )
        {


           char[] a = word1.ToCharArray();
           char[] b = word2.ToCharArray();
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
