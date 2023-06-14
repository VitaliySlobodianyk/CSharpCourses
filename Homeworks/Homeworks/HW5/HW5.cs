using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworks.HW_5.Persons;
using Homeworks.HW_5.Interfaces;

namespace Homeworks.HW_5
{
    public static class HW5
    {
        public static void Execute()
        {

            var teacherAlisaPetrivna = new Teacher("Alisa", "Petrivna");
            var teacherAndriiStepanovych = new Teacher("Andrii", "Stepanovych", 32, "Lviv");

            var vitalii = new Student(firstName: "Vitalii", lastName: "Slobodianyk", 23);
            var mariia = new Student(firstName: "Mariia", lastName: "Petrova");
            var kateryna = new Student(firstName: "Kateryna", lastName: "Karterynivna", 28, "Kyiv");

            var math = new Course("Math",5,teacherAlisaPetrivna);
            var biology = new Course("Biology", 20, teacherAlisaPetrivna);
            var it = new Course("Information Technologies", 15, teacherAndriiStepanovych);

            var studyManager = StudyManager.GetInstance();

            var studentsStudyManagerControlller = (ICollectable<Student>)studyManager;
            var teachersStudyManagerControlller = (ICollectable<Teacher>)studyManager;
            var coursesStudyManagerControlller = (ICollectable<Course>)studyManager;

            studentsStudyManagerControlller.Add(vitalii);
            studentsStudyManagerControlller.Add(mariia);
            studentsStudyManagerControlller.Add(kateryna);

            teachersStudyManagerControlller.Add(teacherAlisaPetrivna);
            teachersStudyManagerControlller.Add(teacherAndriiStepanovych);

            coursesStudyManagerControlller.Add(math);
            coursesStudyManagerControlller.Add(biology);
            coursesStudyManagerControlller.Add(it);

            studyManager.AddStudentToCourse(vitalii, math);
            studyManager.AddStudentToCourse(vitalii, it);
            studyManager.AddStudentToCourse(mariia, it);
            studyManager.AddStudentToCourse(kateryna, biology);

            Console.WriteLine(studentsStudyManagerControlller.ListItems());
            Console.WriteLine(teachersStudyManagerControlller.ListItems());
            Console.WriteLine(coursesStudyManagerControlller.ListItems());
        }
    }
}