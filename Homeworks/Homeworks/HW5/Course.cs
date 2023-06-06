using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Homeworks.HW_5.Persons;

namespace Homeworks.HW_5
{
    public class Course
    {
        public string Name { get; private set; }
        public Teacher Teacher { get; private set; }
        public int AmountOfStudents { get; set; } = 12;

        private List<Student> _students { get; set; }

        public Course(string name)
        {
            Name = name;
            _students = new List<Student>();
        }
        public Course(string name, int amountOfStudents) : this(name)
        {
            AmountOfStudents = amountOfStudents;
        }

        public Course(string name, int amountOfStudents, Teacher teacher) : this(name, amountOfStudents)
        {
           Teacher = teacher;
           teacher.AddCourse(this);
        }

        public void AddStudent(Student student)
        {
            if (_students.Count < AmountOfStudents)
            {
                if (!_students.Contains(student))
                    _students.Add(student);                
            }
            else
            {
                throw new Exception("Maximal amount of students in group has been reached");
            }
        }

        public void RemoveStudent(Student student)
        {
            if (_students.Contains(student))
                _students.Remove(student);
        }

        override public string ToString()
        {
            var resultString = $"""
            Course Name: {Name}
            Teacher: {Teacher?.Name} {Teacher?.Surname}
            Maximal amount of students: {AmountOfStudents}
            Current quantity of students {_students.Count}
            """;
            if (_students.Count > 0)
            {
                resultString += "\nStudents:";
                foreach (var student in _students)
                {
                    resultString += $"\n{student.Name} {student?.Surname}";
                }
            }

            return resultString;
        }
    }
}
