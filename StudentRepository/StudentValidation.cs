using UserLogin;

namespace StudentRepository
{
    public class StudentValidation
    {
        public static Student GetStudentDataByUser(User user)
        {
            if (user.facNumber == null)
            {
                Student s = StudentData.IsThereStudent(user.facNumber);
                if(s != null)
                {
                    return s;
                }
            }
            System.Console.WriteLine("No Student found for the user");
            return null;
        }
    }
}
