using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szemely_OOP_gyak
{
    internal class Cohort
    {
        private string name;
        private List<Student> students;
        private List<Mentor> mentors;

        public Cohort(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Mentors = new List<Mentor>();
        }

        public string Name { get => name; set => name = value; }
        internal List<Student> Students { get => students; set => students = value; }
        internal List<Mentor> Mentors { get => mentors; set => mentors = value; }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {this.name} cohort has {students.Count} students and {mentors.Count} mentors.");
        }
    }
}
