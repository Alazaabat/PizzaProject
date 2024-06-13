using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject.Models
{
    [Serializable]
    internal class User: ICheckable
    {
        public string Email { get; set; }

        public string Password { get; set; }


        public User (string email,string password )
        {
            this.Email = email;
            this.Password = password;
        }

        public override bool Equals(object obj)
        {
           if (obj is null)
            {
                return false;
            }

           if (obj.GetType() != this.GetType())
           {
                    return false;
           }

           User other = obj as User;

            if (other.Email != this.Email)
            {
                return false;
            }
            if(other.Password!=this.Password)
            {
                return false;
            }

            return true;
            
        }
    }
}
