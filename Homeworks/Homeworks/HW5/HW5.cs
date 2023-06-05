using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.HW_5
{
    public static class HW5
    {
        public static void Execute() {
            var vitalii = new Student(firstName: "Vitalii", lastName: "Slobodianyk", 23);
            var mariia = new Student(firstName: "Mariia", lastName: "Petrova");
            var kateryna = new Student(firstName: "Kateryna", lastName: "Karterynivna", 28, "Kyiv");

            var math = new Course("Math");
            var biology = new Course("Biology",20);
            var it = new Course("Information Technologies", 15, "Valentyna Valentynivna");

            StudyManager.AddStudentToCourse(vitalii, math);
            StudyManager.AddStudentToCourse(vitalii, it);
            StudyManager.AddStudentToCourse(mariia, it);
            StudyManager.AddStudentToCourse(kateryna, biology);
            
            math.Print();
            vitalii.Print();

            kateryna.Print();
            StudyManager.RemoveStudentFromCourse(kateryna,it);
            StudyManager.RemoveStudentFromCourse(kateryna, biology);
            kateryna.Print();

            StudyManager.AddStudentToCourse(vitalii, math);
            vitalii.Print();
        }
    }
}