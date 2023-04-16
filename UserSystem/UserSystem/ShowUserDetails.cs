using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSystem
{
    internal class ShowUserDetails
    {
        public static void ShowUser(List<UserClass> userList)
        {
            if (userList.Count>0) {
                    
               var userSortList=from user in userList
                         orderby  user.UserName
                         select user;

                Console.WriteLine("\t\tid\t\t\tname\t\t\temail\t\t\tphonenumber\t\tage");
                foreach (var user in userSortList)
                {
                    Console.Write($"{user.UserId}\t{user.UserName}\t{user.UserEmail}\t{user.UserPhoneNumber}\t");
                    DateTime today = DateTime.Today;
                    int age = today.Year - user.UserDOB.Year;
                    Console.WriteLine("present age {0}", age);
                }
            }
            else
            {
                Console.WriteLine("user list is empty");
            }
        }
    }
}
