using com.bilisimakademisi.course.loops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.bilisimakademisi.course.loops.Controllers
{
    public class UserController
    {//class scope

        User user = new User();
        public User GetUser()
        {//method scope
            user.UserId = 1;
            user.UserName = "soner";
            user.Password = "123";
            user.FullName = "Soner KÖYLÜ";
            user.IsActive = true;

            return user;
        }//method scope
        public User CheckUser(string userName, string password)
        {
            User user = GetUser();

            if (user.UserName == userName && user.Password == password)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        public User Ban()
        {
            user.IsActive = false;

            user.BanExpirationDate = DateTime.Now.AddMinutes(5);

            return user;
        }
    }//class scope
}
