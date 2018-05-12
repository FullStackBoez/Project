using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerGame.Classes
{
    class PersonParser
    {
        public List<Person> list;
        public bool flag = false;
        public PersonParser(List<string> data, string person)
        {
            list = new List<Person>();
            string[] newPerson;
            if (!string.IsNullOrEmpty(person))
                newPerson = person.Split();
            else newPerson = null;
            if (data.Count == 0 && !string.IsNullOrEmpty(person))
            {
                Person tmp = new Person(newPerson[0], Convert.ToInt32(newPerson[1]));
                list.Add(tmp);
            }else
            {
                for(int i = 0; i < data.Count; i++)
                {
                    string[] ss = data[i].Split();
                    Person tmp = new Person(ss[0], Convert.ToInt32(ss[1]));
                    list.Add(tmp);
                    if (i >= 4) break;
                }
                if (!string.IsNullOrEmpty(person))
                {
                    Person tmp1 = new Person(newPerson[0], Convert.ToInt32(newPerson[1]));
                    list.Add(tmp1);
                    list = list.OrderByDescending(x => x.Points).ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (person.Equals(list[i].ToString()) && i < 5) flag = true;
                    }
                }else list = list.OrderByDescending(x => x.Points).ToList();

            }
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (i >= 5) break;
                s += (i + 1) + "." + list[i].ToString()+"\r\n";
            }
                return s;
        }
        public List<string> forData()
        {
            if (list.Count != 0)
            {
                List<string> ss = new List<string>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i >= 5) break;
                    ss.Add(list[i].ToString());
                }
                return ss;
            }
            else return null;
        }
    }
}
