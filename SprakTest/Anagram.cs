using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SprakTest
{
    class Anagram : ITest
    {
        private Dictionary<string, string> wordPairs;

        public Anagram(string fileName)
        {
            wordPairs = new Dictionary<string, string>();
            LoadWords(fileName);
        }

        public void LoadWords(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string wordPair in lines.ToList().GetRange(1, lines.Length-2))
            {
                string[] words = wordPair.Split(':');
                wordPairs.Add(words[0], words[1]);
            }

            foreach (string key in wordPairs.Keys)
            {
                Console.WriteLine(key + " " + wordPairs[key]);
            }
        }

        public bool Evaluate(string word1, string word2, int value)
        {
            return true;
        }
        public string[] GetNextPair()
        {
            return new string[] {"asdf","asdf"};
        }
    }
}
