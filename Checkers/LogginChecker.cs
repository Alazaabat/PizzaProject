using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaProject.Models;
using PizzaProject.Utilities;
namespace PizzaProject
{
    internal class LogginChecker : IChecker
    {
        public static IChecker logginchecker;
        private LogginChecker()
        {

        }
        
        public static IChecker GetChecker()
        {
            if(logginchecker != null)
                return logginchecker;
            return logginchecker = new LogginChecker();
        }


        public bool Check(ICheckable chackable)
        {
         if(chackable is null)
                return false;
            var logger = chackable as User;
            var users = UserIO.GetUsers();
            return users.Exists(user => logger.Equals(user)); 
        }
    }
}
