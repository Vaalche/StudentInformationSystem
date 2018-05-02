using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    public class StudentData
    {
        private static List<Student> testStudents;

        public static void InitTestStudents()
        {
            testStudents = new List<Student>();
            testStudents.Add(new Student("TEst", "Test", "Test", "FKSU", "KSI", "bachelor", "validated", "1235", DateTime.Parse("28.02.2018"), 2, 10, 41));
            testStudents.Add(new Student("Niki", "Niki", "Niki", "FKSU", "KSI", "bachelor", "validated", "12564", DateTime.Parse("25.01.2018"), 2, 10, 4));
            testStudents.Add(new Student("Pesho", "Gosho", "Test", "FTK", "TK", "bachelor", "validated", "12345", DateTime.Parse("23.02.2018"), 4, 1, 12));
        }


        public static List<Student> TestStudents
        {
            get
            {
                return testStudents;
            }

            private set
            {
                testStudents = value;
            }
        }

        public static Student IsThereStudent(string facNumber)
        {
            return (from stud in testStudents
                    where stud.FacNumber.Equals(facNumber)
                    select stud).FirstOrDefault();
            
        }

        public static string PrepareCertificate(Student student)
        {
            StringBuilder cert = new StringBuilder();
            cert.Append("Име: " + student.FirstName + " " + student.SecondName + " " + student.LastName + "\n");
            cert.Append("Факултетен номер: " + student.FacNumber + "\n");
            cert.Append("е бил/а записан/а в специалност " + student.Specialty + " " + "курс " + student.Year + "\n");
            cert.Append("Дата: " + DateTime.Today + "\n");

            return cert.ToString();
        }

        public static void SaveCertificate(string certificate)
        {
            File.WriteAllText("certificate.txt", certificate);
        }

    }
}
