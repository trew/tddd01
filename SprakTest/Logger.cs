using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SprakTest
{
    class Logger
    {
        public void save(string name, int age, bool male, Test test)
        {
            string fileName = name.Split('\\')[1].Split('.')[0];
            fileName += "_";
            fileName += male ? "M" : "F";
            fileName += age;
            fileName += ".txt";
            try
            {
                FileStream fs = File.Open(Directory.GetCurrentDirectory() + "/" + fileName, FileMode.CreateNew);
                fs.Close();
                fs = File.OpenWrite(fileName);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Date: " + DateTime.Now);
                sw.WriteLine("Test: " + name);
                sw.WriteLine("Gender: " + (male ? "Male" : "Female"));
                sw.WriteLine("Age: " + age);
                foreach (string answer in test.Answers)
                {
                    sw.WriteLine(answer);
                }
                sw.Flush();
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
