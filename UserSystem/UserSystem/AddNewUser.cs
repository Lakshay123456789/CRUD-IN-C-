using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSystem
{
     class AddNewUser
    {
        public static void AddNewUserDetails(List<UserClass> userList)
        {

            UserClass Newuser = new UserClass();

            Guid obj = Guid.NewGuid();

            string userId = obj.ToString();

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

            Newuser.UserId = userId;

            Newuser.UserName = userName;
          
            Newuser.UserEmail = userEmail;

            Newuser.UserPhoneNumber = userPhone;

            Newuser.UserDOB = userDoB;

            userList.Add(Newuser);

            Console.WriteLine("successfully add new user");

            ShowUserDetails.ShowUser(userList);
        }
    }
}
