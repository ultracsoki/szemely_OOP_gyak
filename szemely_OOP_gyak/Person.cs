using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szemely_OOP_gyak
{
    internal class Person
    {
        private string name;
        private int age;
        private string gender; //0-true ; 1-false

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Person()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

        public virtual void Introduce()
        {
                Console.WriteLine($"Hi, I'm {this.name}, a {this.age} year old {this.gender}.");
        }
    }
}
