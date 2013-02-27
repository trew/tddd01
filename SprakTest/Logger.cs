using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SprakTest
{
    class Logger
    {
        private string getFileName(string name, int age, bool male, int id) {
            string fileName = name.Split('\\')[1].Split('.')[0];
            fileName += "_";
            fileName += male ? "M" : "F";
            fileName += age;
            if (id > 0) {
                fileName += "_" + id;
            }
            fileName += ".txt";
            return fileName;
        }

        private KeyValuePair<string, FileStream> getFileStream(string name, int age, bool male)
        {
            int id = 0;
            string fileName;
            FileStream fs;
            while (true)
            {
                try
                {
                    fileName = getFileName(name, age, male, id);
                    fs = File.Open(Directory.GetCurrentDirectory() + "/" + fileName, FileMode.CreateNew);
                    return new KeyValuePair<string,FileStream>(fileName, fs);
                }
                catch (IOException e)
                {
                    if (e.Message.EndsWith("already exists.") && id < 100)
                    {
                        id++;
                    }
                    else
                        return new KeyValuePair<string, FileStream>();
                }
            }
        }

        public void save(string name, int age, bool male, Test test)
        {
            try
            {
                KeyValuePair<string, FileStream> filePair = getFileStream(name, age, male);
                if (filePair.Key.Length == 0)
                {
                    Console.WriteLine("Cannot write results.");
                    return;
                }
                string fileName = filePair.Key;
                FileStream fs = filePair.Value;
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
