using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectPRG
{
    
   
        class Users
        {
            private string username;
            private string password;

            public string Password { get => password; set => password = value; }
            public string Username { get => username; set => username = value; }

            public Users(string username, string password)
            {
                this.Username = username;
                this.password = password;

            }
            public Users()
            {

            }
            public override string ToString()
            {
                return string.Format("{0},{1}", Username, password);

            }
            public List<Users> GetUsers()
            {
                List<Users> user = new List<Users>();
               
                user.Add(new Users("loyiso", "1234"));
                user.Add(new Users("jodash", "1234"));

                return user;
            }


        }


    }

