using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;
        public Admin(bool isSuperAdmin, string section, string password, string username):base(password, username)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }
        public void end()
        {
            IsSuperAdmin = false;
            Section = null;

        }


    }
}
