using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
        private static List<User> testUsers;


        public static void ResetTestUserData()
        {
            testUsers = new List<User>();
            testUsers.Add(new User("valio", "12345", "", (int)UserRoles.ADMIN, DateTime.Now, DateTime.MaxValue));
            testUsers.Add(new User("nikii", "54321", "12564", (int)UserRoles.STUDENT, DateTime.Now, DateTime.MaxValue));
            testUsers.Add(new User("mitaka", "11111", "", (int)UserRoles.PROFESSOR, DateTime.Now, DateTime.MaxValue));
        }

        public static List<User> TestUsers
        {
            get
            {
                return testUsers;
            }
            set
            {
                testUsers = value;
            }
        }

        public static User IsUserPassCorrect(string username, string password)
        {
            foreach (User testUser in TestUsers)
            {
                if (username.Equals(testUser.username) && password.Equals(testUser.password))
                {
                    return testUser;
                }
            }
            return null;
        }

        public static void SetUserActiveTo(int userIndex, DateTime newDateActiveTo)
        {
                    Logger.LogActivity("Промяна на активност на" + TestUsers[userIndex]);
                    TestUsers[userIndex].dateActiveTo = newDateActiveTo;
        }

        public static void AssignUserRole(int userIndex, UserRoles role)
        {
                    Logger.LogActivity("Промяна на роля на" + TestUsers[userIndex].username);
                    TestUsers[userIndex].role = (int)role;
        }

        static public Dictionary<string, int> AllUsersUsernames()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 0; i < TestUsers.Count; i++)
            {
                result.Add(TestUsers[i].username, i);
            }
            return result;
        }
    }
}
