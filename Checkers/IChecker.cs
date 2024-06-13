using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaProject.Models;
namespace PizzaProject
{
    internal interface IChecker
    {
        bool Check(ICheckable chackable);
    }
}
