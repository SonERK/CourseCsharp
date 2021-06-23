using com.bilisimakademisi.course.arrays.Helpers;
using com.bilisimakademisi.course.arrays.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace com.bilisimakademisi.course.arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> classes = new List<string>();

            classes.Add("1A");
            classes.Add("1B");
            classes.Add("1C");

            classes.Remove("1B");

            var users = new List<User>
            {
                new User { UserId = 1 },
                new User { UserId = 2 },
                new User { UserId = 3 },
                new User { UserId = 4 }
            };

            //User usr = new User();

            //users.Add(usr);

            users.AddRange(users);

            //var container = new List<User>();

            //for (int i = 0; i < users.Count; i++)
            //{
            //    if (users[i].UserId == 1)
            //    {
            //        container.Add(users[i]);
            //    }
            //}

           // var number = new int[2] { 1, 2 };

            var container = users.Where(user => user.UserId == 1);

            var result = users.Count(c => c.UserId == 1);

            var isContain = users.Any(u=>u.UserId>2);

            foreach (var item in container)
            {
                // string text = "User Id : " + item.UserId;

                Console.WriteLine($"User Id: {item.UserId}");
            }

            #region GenericClass
            //GenericArray<int> numbers = new GenericArray<int>();

            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);

            //GenericArray<string> cities = new GenericArray<string>();

            //cities.Add("Vancouver");
            //cities.Add("Ohio");
            //cities.Add("Ottawa");

            //GenericArray<User> users = new GenericArray<User>();

            //User user = new User();
            //user.UserId = 1;

            //User user2 = new User
            //{
            //    UserId = 2
            //};

            //var user3 = new User
            //{
            //    UserId = 3
            //};

            //users.Add(user);
            //users.Add(user2);
            //users.Add(user3);

            #endregion

            #region SimpleLoginExample

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

            //User[] users = new User[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    User user = new User();
            //    user.FullName ="Soner " + i.ToString();
            //    user.UserId = i;

            //    users[i] = user;
            //}

            //UserHelper helper = new UserHelper();

            //users = helper.ResizeArray(users);
            //users = helper.ResizeArray(users);
            //users = helper.ResizeArray(users);
            //users = helper.ResizeArray(users);
            //users = helper.ResizeArray(users);
            //users = helper.ResizeArray(users);
            //users = helper.ResizeArray(users);

            //Console.WriteLine(total);

            #endregion

            Console.ReadLine();
        }
    }
}
