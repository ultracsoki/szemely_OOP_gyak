using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szemely_OOP_gyak
{
    internal class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level) : base(name,age,gender)
        {
            this.Level = level;
        }
        public string Level { get => level; set => level = value; }

        public Mentor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            this.level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine($"My goal is: Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {this.level} mentor.");
        }

    }
}
