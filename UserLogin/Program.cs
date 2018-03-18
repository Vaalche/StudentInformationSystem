using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {

        static void ShowMenu(User user)
        {
            Console.WriteLine("Choose an option:");
            if (RightsGranted.HasRights((UserRoles)user.role, RoleRights.CanEditUsers))
            {
                Console.WriteLine("1. Change user role");
                Console.WriteLine("2. Change account active date");
                Console.WriteLine("3. Users list");
            }
            if (RightsGranted.HasRights((UserRoles)user.role, RoleRights.CanSeeLogs))
            {
                Console.WriteLine("4. View log");
                Console.WriteLine("5. View Session Log");
            }
            Console.WriteLine("0. Exit");
        }

        static void SelectMenuOption(User user)
        {
            int option;
            while (true)
            {
                Console.Clear();
                ShowMenu(user);
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Select new role: ");
                        UserRoles role = (UserRoles)int.Parse(Console.ReadLine());
                        UserData.AssignUserRole(UserData.AllUsersUsernames()[user.username], role);
                        break;
                    case 2:
                        Console.Write("Enter new active date: ");
                        DateTime dt = Convert.ToDateTime(Console.ReadLine());
                        UserData.SetUserActiveTo(UserData.AllUsersUsernames()[user.username], dt);
                        break;
                    case 3:
                        Dictionary<string, int> allUsers = UserData.AllUsersUsernames();
                        foreach (KeyValuePair<string, int> u in allUsers)
                        {
                            Console.WriteLine(u.Key);
                        }
                        break;
                    case 4:
                        StreamReader sr = new StreamReader("log.txt");
                        string log = sr.ReadToEnd();
                        Console.WriteLine(log);
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Insert a keyword: ");
                        string filter = Console.ReadLine();
                        Console.WriteLine(Logger.GetCurrentSessionActivities(filter));
                        Console.ReadLine();
                        break;
                    case 0: return;
                    default: continue;
                }
            }
        }
        static void Main(string[] args)
        {
            UserData.ResetTestUserData();
            RightsGranted.InitRoleRights();

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();


            LoginValidation validator = new LoginValidation(username, password, Console.WriteLine);
            User user = null;

            if (validator.ValidateUserInput(ref user))
            {
                SelectMenuOption(user);
            }
        }
    }
}
