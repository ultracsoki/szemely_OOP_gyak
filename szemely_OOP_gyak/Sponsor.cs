using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szemely_OOP_gyak
{
    internal class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base(name,age,gender)
        {
            this.company = company;
            this.hiredStudents = 0;
        }

        public Sponsor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            this.company = "Google";
            this.hiredStudents = 0;
        }

        public string Company { get => company; set => company = value; }
        public int HiredStudents { get => hiredStudents; set => hiredStudents = value; }

        public override void GetGoal()
        {
            Console.WriteLine($"My goal is: Hire brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {this.company} and hired {this.hiredStudents} students so far.");
        }

        public void Hire()
        {
            this.hiredStudents++;
        }
    }
}
