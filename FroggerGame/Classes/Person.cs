using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroggerGame.Classes
{
    class Person
    {
        private int points;
        private string name;
        public int Points { get { return points; } set { points = value; } }

        public Person(string name,int points)
        {
            this.name = name;
            this.points = points;
        }

        public override string ToString()
        {
            return name + " " + points;
        }
    }
}
