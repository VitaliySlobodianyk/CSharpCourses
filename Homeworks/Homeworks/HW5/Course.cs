using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Homeworks.HW_5.Interfaces;
using Homeworks.HW_5.Persons;


namespace Homeworks.HW_5
{
    public class Course : ICollectable<Student>, IDescribable
    {
        public string Name { get; private set; }
        public Teacher Teacher { get; private set; }
        public int AmountOfStudents { get; set; } = 12;

        private List<Student> _students;
        public List<Student> List
        {
            get { return _students; }
            set { }
        }

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

        public void Add(Student student)
        {
            if (_students.Count < AmountOfStudents && !_students.Contains(student))
            {
                _students.Add(student);
            }
            else if (_students.Count >= AmountOfStudents)
            {
                throw new Exception("Group is full");
            }
        }

        public string DescribeYourself()
        {
            var resultString = $"""
           
            Course Name: {Name}
            Teacher: {Teacher?.Name} {Teacher?.Surname}
            Maximal amount of students: {AmountOfStudents}
            Current quantity of students {_students.Count}
            """;
            if (_students.Count > 0)
            {
                resultString += ListItems();
            }

            return resultString;
        }


        public string ListItems()
        {
            var resultString = "\nStudents:";
            _students.ForEach(student =>
            {
                resultString += $"\n {student.Name} {student.Surname}";
            });
            return resultString;
        }
    }
}
