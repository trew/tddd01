using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SprakTest
{
    interface ITest
    {
        void LoadWords(string fileName);
        bool Evaluate(string word1, string word2, int value);
        string[] GetNextPair();
    }
}
