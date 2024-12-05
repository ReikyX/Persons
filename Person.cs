using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Personen
{
    internal class Person
    {
        public string name;
        public int alter;
        public string beruf;

        public Person(string _name, int _alter, string _beruf)
        {
            name = _name;
            alter = _alter;
            beruf = _beruf;
        }

        public void Begruessung(string userName)
        {
            Console.WriteLine($"Hallo {userName}! Ich bin {name}.");

        }

        public void Info()
        {
            Console.WriteLine($"\n\nName:\t{name}\nAlter:\t{alter}\nBeruf:\t{beruf}");
        }
    }
}
