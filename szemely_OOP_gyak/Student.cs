using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szemely_OOP_gyak
{
    internal class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name,age,gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }

        public Student()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            this.previousOrganization = "The School of Life";
            this.skippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {this.previousOrganization} who skipped {this.skippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            this.skippedDays += numberOfDays;
        }
    }
}
