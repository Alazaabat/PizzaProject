using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaProject.Models;
namespace PizzaProject.Utilities
{
    internal static class UserIO
    {
        private static readonly string _path = "..\\..\\Files\\Users.bin";
        public static void WriteUser(User user)
        {
            if (user is null)
                return;
            FileInputOutput.WriteObject(_path,user);
        }

       public static User ReadUser()
        {
            object user=FileInputOutput.ReadObject(_path);
            return user as User;
        }
       public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (FileStream file=new FileStream(_path,FileMode.Open))
            {
                object obj = FileInputOutput.ReadObject(file);
                while(obj !=null)
                {
                    User user = obj as User;
                    users.Add(user);
                    obj=FileInputOutput.ReadObject(file);
                }
            }
            return users;
        }
       

    }
}
