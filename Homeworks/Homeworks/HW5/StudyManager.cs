
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworks.HW_5.Persons;

namespace Homeworks.HW_5
{
    public static class StudyManager
    {
        public static void AddStudentToCourse(Student student, Course course) {
            course.AddStudent(student);
            student.AddCourse(course);
        }

        public static void RemoveStudentFromCourse(Student student, Course course)
        {
            course.RemoveStudent(student);
            student.DeleteCourse(course);
        }
    }
}
