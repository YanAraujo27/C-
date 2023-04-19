using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4V2.Models
{
    public class Student
    {
        public int codeOfStudent { get; set; }
        public string nameOfStudent { get; set; }
        public string phoneOfStudent { get; set; }
        public string emailOfStudent { get; set; }
        public string courseOfStudents { get; set; }

        public Student(int codeOfStudent, String nameOfStudent, string phoneOfStudent, string emailOfStudent, String courseOfStudents) { 
            
            this.codeOfStudent = codeOfStudent;
            this.nameOfStudent = nameOfStudent;
            this.phoneOfStudent = phoneOfStudent;
            this.emailOfStudent = emailOfStudent;
            this.courseOfStudents = courseOfStudents;

        }

        public Student()
        {
        }
    }
}
