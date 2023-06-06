using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworks.HW_5;

namespace Homeworks.HW_5.Persons
{
    public class Student : Person
    {
        private List<Course> _courses { get; set; }

        public Student(string firstName, string lastName) : this(firstName, lastName, 0, "UNKNOWN")
        {
        }

        public Student(string firstName, string lastName, int age) : this(firstName, lastName, age, "UNKNOWN")
        {
        }

        public Student(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
        {
            _courses = new List<Course>();
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

        public override string DescribeYourself()
        {
            var resultString = $"""
                Student:
                {base.DescribeYourself()}
                """;
            if (_courses.Count > 0)
            {
                resultString += "\nCourses Studied:";
                foreach (var course in _courses)
                {
                    resultString += $"\n {course.Name}";
                }
            }

            return resultString;
        }

    }
}
