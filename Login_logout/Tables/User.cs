using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    public class User
    {
        string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        
        public override string ToString()
        {
            return Login;
        }
    }
}
