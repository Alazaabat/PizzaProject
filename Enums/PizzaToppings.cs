using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject.Enums
{
    [Flags]
    internal enum PizzaToppings
    {
        None=0,
        ExtraCheese=1,
        Onion=2,
        Mushrooms=4,
        Olives=8,
        Tomatoes=16,
        Peppers=32
    }
}
