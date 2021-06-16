using com.bilisimakademisi.course.loops.Controllers;
using com.bilisimakademisi.course.loops.Models;
using System;

namespace com.bilisimakademisi.course.loops
{
    class Program
    {
        static void Main(string[] args)
        {

            UserController userController = new UserController();

            User user;

            string userName = string.Empty;
            string password = string.Empty;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Kullanıcı Adınızı Yazınız :");

                userName = Console.ReadLine();

                Console.WriteLine("Şifrenizi Giriniz :");

                password = Console.ReadLine();

                user = userController.CheckUser(userName, password);

                if (user != null)
                {
                    Console.WriteLine("Welcome " + user.FullName);

                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı Bilgileri Hatalı !");
                }

                int count = i + 1;

                if (count==5)
                {
                    user = userController.Ban();

                    Console.WriteLine("Kullanıcı Hesabı Geçici olarak kapatıldı");
                }

                Console.WriteLine("Deneme sayısı :" + count);
                Console.WriteLine("**********************************************");
            }


            Console.ReadLine();
        }
    }
}
