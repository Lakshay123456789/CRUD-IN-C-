using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UserSystem
{
    static class ValidationUtlity
    {
        public static string CheckName()
        {

            string userName;
            while (true)
            {
                Console.WriteLine("Enter User Name");
                    userName=Console.ReadLine().ToUpper();

                if(userName.Contains("QUIT")) {       
                    return "-1";
                }
                    if (Regex.Match(userName, "^[a-zA-Z\\s]*$").Success && userName.Length>3)
                    {

                    return userName;
                }
                    else
                    {
                        Console.WriteLine("invalid name please write correct name");
                    }
               
            }
      
        }
        public static string CheckEmail() { 

            string userEmail;

          while(true)
            {
                Console.WriteLine("Enter User Email");
                userEmail =Console.ReadLine().ToLower();
                if (userEmail.Contains("quit"))
                {
                    return "-1";

                }
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(userEmail);
                if (match.Success)
                {
                    return userEmail;
                }
                else
                {
                    Console.WriteLine("invalid email please enter correct email");
                }
            }
         
        }
        public static string CheckPhone()
        {
            string userPhone;
            while(true)
            {
                Console.WriteLine("Enter User Phone");
                userPhone = Console.ReadLine();

                if (userPhone.ToLower().Contains("quit"))
                {
                    return "-1";

                }
                if (Regex.Match(userPhone, @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}").Success && userPhone.Length==10)
                {
                    return userPhone;
                }
                else
                {
                    Console.WriteLine("Invalid phone number");
                }

            }
        }
        public static DateTime CheckDob()
        {
            string userDob;
            while (true)
            { 
                
                Console.WriteLine("Enter User Date of Birth MM/dd/yyyy");
                userDob = Console.ReadLine();
                if (userDob.Contains("quit"))
                {
                    return DateTime.Today;

                }
                bool isValid;
                DateTime dt;
                isValid = DateTime.TryParseExact(userDob, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out dt);
                if (isValid )
                {
                   
                    try
                    {
                        DateTime bday = DateTime.Parse(userDob);
                        DateTime today = DateTime.Today;
                

                        int age = today.Year - bday.Year;
                        if (age >= 18)
                        {
                            return bday;

                        }

                        Console.WriteLine("your age must atleast 18 years old");
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("invalid date please correct birth Date ");
                    }
                }
                else { 
                    Console.WriteLine("invalid format date format");
                }


            }

        }
    }

}
