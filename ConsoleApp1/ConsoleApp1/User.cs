using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class User
    {
        private string _username;
        private string _password;
        public string usPw
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length == 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Enter the correctly");
                }
            }
        }
        public string pwUs
        {
            get
            {
                return _password;
            }
            set
            {
                bool bignumber = false;

                for (int i = 0; i < value.Length; i++)
                {
                    
                    
                    int check = (int)value[i];
                    if (check > 65 && check < 90)
                    {
                        bignumber=true;
                    }
                    
                }
                bool sinvol = false;
                for (int i = 0; i < value.Length; i++)
                {
                    
                    int check = (int)value[i];
                    if (check >=58 && check <= 64)
                    {
                        sinvol=true;
                    }
                }
                if (bignumber == true && sinvol == true)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Enter the password correctly");
                }
                
            }
        }
        public User(string password, string username)
        {
              _password = password;
            _username = username;
        }

    }
}
