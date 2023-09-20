using System;
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
            StreamWriter sw = new StreamWriter("People.txt", true);
            sw.WriteLine("Name: "+PersonName+" Age: "+PersonAge);
            sw.Close();
        }
        public List<string> ShowAll()
        {
           List<string> People = new List<string>();
            string AllPeople = "";
            StreamReader sr = new StreamReader("People.txt", Encoding.UTF8);
            if (sr != null)
            {
                //AllPersons = AllPersons += sr.ReadLine() + '\n';
                People.Add(sr.ReadLine());
            }
            //AllPeople=string.Join("\n", People);
            sr.Close();
            return People;
        }
    }
}
