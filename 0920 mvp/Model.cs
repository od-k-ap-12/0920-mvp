﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _0920_mvp
{
    public class Model: IModel
    {
        public string PersonName { get; set; }
        public string PersonAge { get; set; }

        public void Save()
        {
            if (PersonName != "" && PersonAge != "")
            {
                StreamWriter sw = new StreamWriter("People.txt", true);
                sw.WriteLine("Name: " + PersonName + " Age: " + PersonAge);
                sw.Close();
            }
        }
        public string ShowAll()
        {
            string AllPeople = "";
            StreamReader sr = new StreamReader("People.txt", Encoding.UTF8);
            AllPeople = File.ReadAllText("People.txt");
            sr.Close();
            return AllPeople;
        }
        public List<string> Search()
        {
            List<string> ParsePeople=new List<string>();
            StreamReader sr = new StreamReader("People.txt", Encoding.UTF8);
            if (sr != null)
            {
                while (!sr.EndOfStream)
                {
                    ParsePeople.Add(sr.ReadLine() + '\n');
                }
            }
            sr.Close();
            return ParsePeople;
        }
    }
}
