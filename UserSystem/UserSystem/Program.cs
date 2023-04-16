using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UserSystem
{
     class Program
    {
       public static void Main()
        {

            CultureInfo provider = CultureInfo.InvariantCulture;
            List<UserClass> UserClasslist = new List<UserClass>{
             new UserClass
             {
                 UserId="e24e1545-47f6-4f16-9c2d-aa712e21f0df",
                 UserName="lakshay kamboj",
                 UserEmail="lakshaykamboj051@gmail.com",
                 UserPhoneNumber="9729561434",
                 UserDOB =DateTime.ParseExact("01/05/2001", "MM/dd/yyyy", provider),
                  
                }
            };

            while (true)
            {
                bool quit = false;
                Console.WriteLine("\n\t\t\t\t Welcome to User Management System");
                Console.WriteLine("1.Enter show All Users");
                Console.WriteLine("2.Enter Add New  User");
                Console.WriteLine("3.Enter Edit  User");
                Console.WriteLine("4.Enter Delete  User");
                Console.WriteLine("5.Enter Export into CSV file all Users");
                Console.WriteLine("6.Quit application");
                try
                {
                    int choiceUser = int.Parse(Console.ReadLine());
                    switch (choiceUser)
                    {

                        case 1:
                            ShowUserDetails.ShowUser(UserClasslist);
                            break;
                        case 2:
                            AddNewUser.AddNewUserDetails(UserClasslist);
                            break;
                        case 3:
                            UpdateUserDetails.UpdateUser(UserClasslist);
                            break;
                        case 4:
                            DeleteUserDetails.DeleteUser(UserClasslist);
                            break;
                        case 5:
                            Export.ExportFile(UserClasslist);
                            break;

                        case 6:
                            //  quit = true;
                            SendEmail.SendMailUser(UserClasslist);
                            break;

                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("invalid input");

                }
                if (quit)
                {
                    break;
                }
            }
       
         
        }
    }
}
