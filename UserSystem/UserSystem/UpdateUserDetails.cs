using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSystem
{
    internal class UpdateUserDetails
    {
        public static void UpdateUser(List<UserClass> userList)
        {
            if (userList.Count > 0) {
                while (true) {
                    ShowUserDetails.ShowUser(userList);
                    Console.WriteLine("enter the user Id");

                 

                string userId = Console.ReadLine();
                Guid id;
                if (Guid.TryParse(userId, out id))
                {
                    foreach (var user in userList)
                    {
                        if (user.UserId == userId)
                        {
                            string userName = ValidationUtlity.CheckName();

                            if (userName.Equals("-1"))
                                return;

                            string userEmail = ValidationUtlity.CheckEmail();

                            if (userEmail == "-1")
                                return;

                            string userPhone = ValidationUtlity.CheckPhone();

                            if (userPhone == "-1")
                                return;

                            DateTime userDoB = ValidationUtlity.CheckDob();

                            if (userDoB == DateTime.Today)
                                return;

                            user.UserName = userName;

                            user.UserEmail = userEmail;

                            user.UserPhoneNumber = userPhone;

                            user.UserDOB = userDoB;

                            Console.WriteLine("successfully edit user details");
                                return;
                        }
                    }
                    Console.WriteLine("invalid user id ");
                }
                else
                {
                    Console.WriteLine("invalid user id please enter correct id");
                }

            }
        }
            else
            {
                Console.WriteLine("list is empty");
            }
        }

    }
}
