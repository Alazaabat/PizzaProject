using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using PizzaProject.Enums;
using System.Windows.Forms;
namespace PizzaProject.Utilities
{
    internal static class Utility
    {
        public static int  ToppingPrice(PizzaToppings topping)
        {

           switch(topping)
            {
                case PizzaToppings.None:
                    return 0;
                case PizzaToppings.Olives:
                case PizzaToppings.Peppers:
                case PizzaToppings.Onion:
                    return 1;
                case PizzaToppings.Mushrooms:
                    return 2;
                case PizzaToppings.ExtraCheese:
                    return 3;
                case PizzaToppings.Tomatoes:
                    return 2;
                default:
                    throw new ArgumentException("Unrecognized topping", nameof(topping));
            }
        }

        public static int ToppingsPrice(PizzaToppings toppings)
        {
            int price = 0;
            Array allToppings = Enum.GetValues(toppings.GetType());
            foreach (PizzaToppings topping in allToppings)
            {
                if ((topping & toppings) == topping)
                    price += ToppingPrice(topping);
            }
            return price;
        }

        public static int PizzaSizeToInt(PizzaSize size) => (int)size;
        public static int PizzaCrustToInt(PizzaCrust crust) => (int)crust;

        public static string AddIntToString(this string str,int num)
        {
            int result=0;
            bool parseDone = int.TryParse(str, out result);
            if (!parseDone)
                throw new ArgumentException("The input string is not a valid integer.", nameof(str));
            result += num;
            return result.ToString();
        }
        public static void AddPriceToTotal(System.Windows.Forms.Label TotalPriceLabel,int addition)
        {
            TotalPriceLabel.Text = TotalPriceLabel.Text.Substring(0, TotalPriceLabel.Text.Length - 1);
            TotalPriceLabel.Text = TotalPriceLabel.Text.AddIntToString(addition);
            TotalPriceLabel.Text += "$";
        }
       
        public static void SetEnableGroupBoxes(IEnumerable<GroupBox> groupBoxes,bool Enabled)
        {
            foreach (var groupBox in groupBoxes)
            {
                groupBox.Enabled = Enabled;
            }
        }
    
    }
}
