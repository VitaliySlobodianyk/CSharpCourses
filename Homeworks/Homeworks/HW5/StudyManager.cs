
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworks.HW_5.Interfaces;
using Homeworks.HW_5.Persons;

namespace Homeworks.HW_5
{
    public class StudyManager : ICollectable<Student>, ICollectable<Teacher>, ICollectable<Course>
    {
        private static StudyManager? _studyManager;

        private StudyManager()
        {
            _students = new List<Student>();
            _courses = new List<Course>();
            _teachers = new List<Teacher>();
        }

        public static StudyManager GetInstance()
        {
            _studyManager ??= new StudyManager();

            return _studyManager;
        }

        private List<Student> _students;
        List<Student> ICollectable<Student>.List { get { return _students; } set { } }

        private List<Course> _courses;
        List<Course> ICollectable<Course>.List { get { return _courses; } set { } }

        private List<Teacher> _teachers;
        List<Teacher> ICollectable<Teacher>.List { get { return _teachers; } set { } }

        public void AddStudentToCourse(Student student, Course course)
        {
            ((ICollectable<Student>)course).Add(student);
            ((ICollectable<Course>)student).Add(course);
        }

        public void RemoveStudentFromCourse(Student student, Course course)
        {
            ((ICollectable<Student>)course).Remove(student);
            ((ICollectable<Course>)student).Remove(course);
        }

        string ICollectable<Course>.ListItems() {
         
            var resultString = "\nCourses:";
            _courses.ForEach(course =>
            {
                resultString += $"\n { course.DescribeYourself()}";
            });
            return resultString;
        }

        string ICollectable<Teacher>.ListItems()
        {
            var resultString = "\nTeachers:";
            _teachers.ForEach(teacher =>
            {
                resultString += $"\n {teacher.DescribeYourself()}";
            });
            return resultString;
        }

        string ICollectable<Student>.ListItems()
        {
            var resultString = "\nStudents:";
            _students.ForEach(student =>
            {
                resultString += $"\n {student.DescribeYourself()}";
            });
            return resultString;
        }
    }
}
