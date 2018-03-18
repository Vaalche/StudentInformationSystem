using System;

namespace StudentRepository
{
    public class Student
    {
        public string firstName;
        public string secondName;
        public string lastName;
        public string faculty;
        public string specialty;
        public string degree;
        public string status;
        public string facNumber;
        public DateTime lastValidation;
        public int year;
        public int stream;
        public int group;

        public Student(string firstName, string secondName, string lastName, string faculty, string specialty,
                       string degree, string status, string facNumber, DateTime lastValidation, int year, int stream, int group)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.faculty = faculty;
            this.specialty = specialty;
            this.degree = degree;
            this.status = status;
            this.facNumber = facNumber;
            this.lastValidation = lastValidation;
            this.year = year;
            this.stream = stream;
            this.group = group;
        }

    }
}
