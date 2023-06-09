
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworks.HW_5.Interfaces;
using Homeworks.HW_5.Persons;

namespace Homeworks.HW_5
{
    public static class StudyManager
    {
        public static void AddStudentToCourse(Student student, Course course) {
            ((ICollectable<Student>)course).Add(student);
            ((ICollectable<Course>)student).Add(course);
        }

        public static void RemoveStudentFromCourse(Student student, Course course)
        {
            ((ICollectable<Student>)course).Remove(student);
            ((ICollectable<Course>)student).Remove(course);
        }
    }
}
