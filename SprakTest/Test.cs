using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SprakTest
{
    abstract class Test
    {
        private List<KeyValuePair<string, string>> wordPairs;
        private List<string> answers;

        public Test( string fileName )
        {
            wordPairs = new List<KeyValuePair<string, string>>();
            answers = new List<string>();
            LoadWords(fileName);
        }

        void LoadWords(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string wordPair in lines.ToList().GetRange(1, lines.Length - 2))
            {
                string[] words = wordPair.Split(':');
                wordPairs.Insert(wordPairs.Count, new KeyValuePair<string, string>(words[0], words[1]));

            }
        }
        public abstract bool Evaluate(string word1, string word2, int value);

        public List<String> Answers { get { return answers; } }

        public void addAnswer(string answer)
        {
            answers.Add(answer);
        }

        public virtual KeyValuePair<string, string> GetNextPair()
        {
            if (wordPairs.Count != 0)
            {
                KeyValuePair<string, string> firstPair = wordPairs.First();
                wordPairs.RemoveAt(0);
                return firstPair;
            }
            else
            {
                return new KeyValuePair<string, string>("", "");
            }
        }
    }
}
