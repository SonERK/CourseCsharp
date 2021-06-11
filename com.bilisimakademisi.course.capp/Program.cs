using System;

namespace com.bilisimakademisi.course.capp
{
    class Program
    {
        
        static void Main(string[] args)
        {   /*Comment*/
            //Console.WriteLine("Hello World!");

            #region BuiltInTypes
            //bool isActive = false;
            //byte number = 255;
            //char character = '5';
            //float number2 = 15;
            //double number3 = 20;
            //decimal number4 = 200;
            //int number5 = 2147483647;
            //short number6 = 2535;
            //object obj = "";
            //object obj2 = 1;
            //string term = "Once upon a time in Arnavutkoy 12 $";

            //dynamic number7 = 7;
            //number7 = "";

            #endregion

            #region ClassExample
            //User _user = new User();

            //_user.UserId = 1;
            //_user.FullName = "soner.koylu";

            //User _user2 = _user;

            //_user2.FullName = "soner";

            //Console.WriteLine(_user.UserId);
            //Console.WriteLine(_user.FullName);

            //Console.WriteLine(_user2.UserId);
            //Console.WriteLine(_user2.FullName);

            #endregion

            #region StructExample
            //UserStruct _user = new UserStruct();
            //_user.UserId = 1;
            //_user.FullName = "soner.koylu";

            //UserStruct _user2 = _user;
            //_user2.FullName = "soner";

            //Console.WriteLine(_user.FullName);
            //Console.WriteLine(_user2.FullName);
            #endregion

            #region EnumExample
            Logger _logger = Logger.Database;
           
            if (_logger==Logger.SMS)
            {
                //Sms At
            }
            #endregion
        }
    }
}
