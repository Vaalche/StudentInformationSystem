using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentData.InitTestStudents();
            Console.Write("Enter fac number: ");

            string facNumber = Console.ReadLine();

            Student student = StudentData.IsThereStudent(facNumber);

            string cert = StudentData.PrepareCertificate(student);

            Console.WriteLine(cert);
            StudentData.SaveCertificate(cert);
        }
    }
}
