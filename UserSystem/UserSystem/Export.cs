using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSystem
{
    internal class Export
    {
        public static void ExportFile(List<UserClass> UList)
        {
            if (UList.Count> 0)
            {
                string path=AppDomain.CurrentDomain.BaseDirectory+"export.csv";
                using(FileStream file= new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    using(StreamWriter fileStream =new StreamWriter(file))
                    {
                        fileStream.WriteLine($"Id name email phone DOB");
                        foreach(var item in UList)
                        {
                            fileStream.WriteLine($"{item.UserId} {item.UserName} {item.UserEmail}{item.UserPhoneNumber}{item.UserDOB}");
                        }
                        Console.WriteLine("add data successfully into CSvV file");
                    }
                }

            }
        }
    }
}
