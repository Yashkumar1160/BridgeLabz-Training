using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    public class UserRegistration
    {
        //method to register user
        public void RegisterUser(string username, string email, string password)
        {
            //check username
            if (string.IsNullOrEmpty(username))
            {
                //throw exception if username is invalid
                throw new ArgumentException("Invalid username");
            }

            //check email
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                //throw exception if email is invalid
                throw new ArgumentException("Invalid email");
            }

            //check password
            if (string.IsNullOrEmpty(password))
            {
                //throw exception if password is invalid
                throw new ArgumentException("Invalid password");
            }

        }
    }
}
