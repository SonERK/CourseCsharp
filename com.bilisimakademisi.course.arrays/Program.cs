using com.bilisimakademisi.course.arrays.Helpers;
using com.bilisimakademisi.course.arrays.Model;
using System;

namespace com.bilisimakademisi.course.arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n1,n2,n3,n4,total;
            //n1 = Convert.ToInt32(Console.ReadLine());
            //n2 = Convert.ToInt32(Console.ReadLine());
            //n3 = Convert.ToInt32(Console.ReadLine());
            //n4 = Convert.ToInt32(Console.ReadLine());

            //int total = 0;

            //int[] numbers = new int[4];

            //numbers[0] = 1;

            //for (int i = 0; i < 4; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total = +total + numbers[i];
            //}

            //string[] names = new string[4];

            //for (int i = 0; i < 4; i++)
            //{
            //    names[i] = Console.ReadLine();
            //}

            User[] users = new User[5];

            for (int i = 0; i < 5; i++)
            {
                User user = new User();
                user.FullName ="Soner " + i.ToString();
                user.UserId = i;

                users[i] = user;
            }

            UserHelper helper = new UserHelper();

            users = helper.ResizeArray(users);
            users = helper.ResizeArray(users);
            users = helper.ResizeArray(users);
            users = helper.ResizeArray(users);
            users = helper.ResizeArray(users);
            users = helper.ResizeArray(users);
            users = helper.ResizeArray(users);

            //Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
