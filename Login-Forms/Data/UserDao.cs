using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Forms.Data
{
    public class UserDao
    {
        User user;
        public UserDao()
        {
            user = new User() { ID = 1, UserName = "admin", PassWord = "admin", Remember = true };
        }
    }
}
