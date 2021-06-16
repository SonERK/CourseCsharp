using com.bilisimakademisi.course.arrays.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.bilisimakademisi.course.arrays.Helpers
{
    public class UserHelper
    {
        User[] temp;
        public User[] ResizeArray(User[] users)
        {
            temp = new User[users.Length+1];

            for (int i = 0; i < users.Length; i++)
            {
                temp[i] = users[i];
            }

            return temp;
        }
    }
}
