using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.HW_5
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string City { get; private set; }

        private List<Course> _courses { get; set; }

        public Student(string firstName, string lastName)
        {
            _courses = new List<Course>();
            FirstName = firstName;
            LastName = lastName;
        }

        public Student(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            Age = age;
        }

        public Student(string firstName, string lastName, int age, string city) : this(firstName, lastName, age)
        {
            City = city;
        }

        public void AddCourse(Course course)
        {
            if (!_courses.Contains(course))
                _courses.Add(course);
        }
        public void DeleteCourse(Course course)
        {
            if (_courses.Contains(course))
                _courses.Remove(course);
        }

        override public string ToString()
        {
            var resultString = $"""
            Student: {FirstName} {LastName}
            Age: {Age}
            City:{City}
            """;
            if (_courses.Count > 0)
            {
                resultString += $"\nStudies {_courses.Count} subjects:";
                foreach (var course in _courses)
                {
                    resultString += $"\n{course.Name}";
                }
            }

            return resultString;
        }

    }
}
