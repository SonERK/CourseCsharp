using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.bilisimakademisi.course.loops.Models
{
    public class User
    {
        #region HomeWork
        //Property ve Field Farkını araştırınız.
        // int id;
        #endregion

        public int UserId { get; set; }//1
        public string UserName { get; set; }//"soner.koylu"
        public string Password { get; set; }//"123456"
        public string FullName { get; set; }//"Soner KÖYLÜ"
        public bool IsActive { get; set; }//true false
        public DateTime BanExpirationDate { get; set; }
    }
}
