using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSystem
{
    internal class DeleteUserDetails
    {
        public static void DeleteUser(List<UserClass> userList)
        {
            ShowUserDetails.ShowUser(userList);

            if (userList.Count>0)
            {
                while (true)
                {
                    Console.WriteLine("enter the user Id");
                    string userId = Console.ReadLine();
                    Guid guid;
                    if (Guid.TryParse(userId, out guid))
                    {
                        Console.WriteLine("Are you sure delete this details (yes/no)");
                        string comfirmDelete = Console.ReadLine();
                        if (comfirmDelete.ToLower() == "yes")
                        {
                            foreach (var list in userList)
                            {
                                if (list.UserId == userId)
                                {
                                    userList.Remove(list);
                                    Console.WriteLine("user detail successfully deleted");
                                    return;
                                }
                            }
                            Console.WriteLine("this user id not exist ");
                            return;

                        }
                        else if (comfirmDelete.ToLower() == "no")
                        {
                            return;
                        }
                      
                    }
                    else
                    {
                        Console.WriteLine("invalid user id format ");
                    }
                }
            }
            else
            {
                Console.WriteLine("user list is empty");
            }

        }

    
    }
}
