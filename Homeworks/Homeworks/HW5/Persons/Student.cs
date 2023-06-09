using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworks.HW_5;
using Homeworks.HW_5.Interfaces;


namespace Homeworks.HW_5.Persons
{
    public class Student : Person, ICollectable<Course>
    {
        private List<Course> _courses;
        public List<Course> List { get { return _courses; } set { } }

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

        public override string DescribeYourself()
        {
            var resultString = $"""
                Student:
                {base.DescribeYourself()}
                """;
            if (List.Count > 0)
            {
                resultString += "\nCourses Studied:";
                foreach (var course in List)
                {
                    resultString += $"\n {course.Name}";
                }
            }

            return resultString;
        }

    }
}
