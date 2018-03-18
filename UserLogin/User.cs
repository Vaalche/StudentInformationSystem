using System;

namespace UserLogin
{
    public class User
    {
        public String username;
        public String password;
        public String facNumber;
        public Int32 role;
        public DateTime dateCreated;
        public DateTime dateActiveTo;

        public User(string username, string password, string facNumber, int role, DateTime dateCreated, DateTime dateActiveTo)
        {
            this.username = username;
            this.password = password;
            this.facNumber = facNumber;
            this.role = role;
            this.dateCreated = dateCreated;
            this.dateActiveTo = dateActiveTo;
        }
    }
}
