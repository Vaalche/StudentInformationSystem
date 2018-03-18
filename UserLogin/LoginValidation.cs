using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LoginValidation
    {
        private static string currentUserUsername;
        private static UserRoles currentUserRole;

        private String username;
        private String password;
        private String errorMessage;

        public delegate void ActionOnError(string errorMsg);
        private ActionOnError logError;

        public LoginValidation(string username, string password, ActionOnError loggingMethod)
        {
            logError = loggingMethod;
            this.username = username;
            this.password = password;
            
        }

        public bool ValidateUserInput(ref User u)
        {
            u = UserData.IsUserPassCorrect(username, password);

            if (u == null)
            {
                errorMessage = "Invalid user";
                logError(errorMessage);
                return false;
            }

            if (u.username.Equals(String.Empty) || u.username.Length < 5)
            {
                errorMessage = "Invalid username";
                logError(errorMessage);
                return false;
            }
            if (u.password.Equals(String.Empty) || u.password.Length < 5)
            {
                errorMessage = "Invalid password";
                logError(errorMessage);
                return false;
            }
            currentUserRole = (UserRoles)u.role;
            currentUserUsername = u.username;
            Logger.LogActivity("Успешен Login");
            return true;
        }

        public static UserRoles CurrentUserRole
        {
            get
            {
                return currentUserRole;
            }
            set
            {
                currentUserRole = value;
            }
        }

        public String ErrorMessage
        {
            get
            {
                return errorMessage;
            }
        }

        public static string CurrentUserUsername
        {
            get
            {
                return currentUserUsername;
            }

            set
            {
                currentUserUsername = value;
            }
        }
    }
}
