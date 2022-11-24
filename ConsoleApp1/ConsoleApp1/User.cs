using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        private string username;
        private int password;
        private string issignedin;
        private string[] products;


        public User(string username, int password, string issignedin, string[] product)
        {
            string Username = username;
            int Password = password;
            string IsSignedIn = issignedin;
            string[] Products = products;
        }

        private string Username
        {
            get { return username; }
            set
            {
                if (username.Length >= 6 && username.Length <= 25)
                {
                    username = value;
                }
                else
                {
                    Console.WriteLine("Adi duzgun daxil edin");
                }
            }
        }

        private int Password
        {
            get { return password; }
            set
            {
                if (password.Length >= 8 && password.Length <= 25)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Sifreni duzgun daxil edin");
                }
            }
        }
    }
}
