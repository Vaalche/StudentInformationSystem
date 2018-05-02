using System;

namespace StudentRepository
{
    public class Student
    {
        private string firstName;
        private string secondName;
        private string lastName;
        private string faculty;
        private string specialty;
        private string degree;
        private string status;
        private string facNumber;
        private DateTime lastValidation;
        private int year;
        private int stream;
        private int group;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string SecondName
        {
            get
            {
                return secondName;
            }

            set
            {
                secondName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string FirstAndLastName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public string Faculty
        {
            get
            {
                return faculty;
            }

            set
            {
                faculty = value;
            }
        }

        public string Specialty
        {
            get
            {
                return specialty;
            }

            set
            {
                specialty = value;
            }
        }

        public string Degree
        {
            get
            {
                return degree;
            }

            set
            {
                degree = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string FacNumber
        {
            get
            {
                return facNumber;
            }

            set
            {
                facNumber = value;
            }
        }

        public DateTime LastValidation
        {
            get
            {
                return lastValidation;
            }

            set
            {
                lastValidation = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public int Stream
        {
            get
            {
                return stream;
            }

            set
            {
                stream = value;
            }
        }

        public int Group
        {
            get
            {
                return group;
            }

            set
            {
                group = value;
            }
        }

        public Student(string firstName, string secondName, string lastName, string faculty, string specialty,
                       string degree, string status, string facNumber, DateTime lastValidation, int year, int stream, int group)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.Faculty = faculty;
            this.Specialty = specialty;
            this.Degree = degree;
            this.Status = status;
            this.FacNumber = facNumber;
            this.LastValidation = lastValidation;
            this.Year = year;
            this.Stream = stream;
            this.Group = group;
        }

    }
}
