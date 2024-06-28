using PizzaProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaProject.Utilities;
using PizzaProject.Enums;

namespace PizzaProject
{
    public partial class frmPizzaOrder : Form
    {
        private System.ComponentModel.IContainer components = null;
        private PizzaToppings _pizzaToppings = 0;
        private List<RadioButton> sizeRadioButtons;
        private List<RadioButton> crustRadioButtons;
        private List<CheckBox> toppingsCheckBoxButtons;
        private List<RadioButton> eatPlaceRadioButtons;
        private List<GroupBox> groupBoxes;
        public frmPizzaOrder()
        {
            this.sizeRadioButtons=new List<RadioButton>();
            this.crustRadioButtons = new List<RadioButton>();
            this.toppingsCheckBoxButtons = new List<CheckBox>();
            this.eatPlaceRadioButtons = new List<RadioButton>();
            this.groupBoxes = new List<GroupBox>();
            InitializeComponent();
            this.lblResultTotal.Hide();
        }
        private void AddToTotal(bool isChecked,int addition)
        {
            if (!isChecked)
                addition = -addition;
           
            Utility.AddPriceToTotal(this.lblResultTotal, addition);
        }
        private void UpdatePizzaToppings(bool isChecked ,PizzaToppings topping)
        {
            if (isChecked)
                this._pizzaToppings |= topping;
            else
                this._pizzaToppings &= ~topping; // delete the pizza topping by complement
            this.lblResultToppings.Text = GetStringPizzaTopping(this._pizzaToppings);
        }
        private string GetStringPizzaTopping(PizzaToppings pizzaToppings)
        {
            if (pizzaToppings == PizzaToppings.None)
                return "None";
            Array allToppings = Enum.GetValues(_pizzaToppings.GetType());
            StringBuilder stringBuilder = new StringBuilder("");
            foreach (PizzaToppings topping in allToppings)
            {
                if (topping == PizzaToppings.None)
                    continue;
                if((pizzaToppings & topping) == topping)
                    stringBuilder.Append(topping.ToString()+" , ");
            }
            return stringBuilder.ToString(0, stringBuilder.Length - 2);
        }
        private void frmPizzaOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
           Tuple <frmLogin,User> tuple=this.Tag as  Tuple<frmLogin,User>;
            tuple.Item1.Show();
        }

        private void rbSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            
            int addition=Utility.PizzaSizeToInt(PizzaSize.Small);
            AddToTotal(rbSmallSize.Checked,addition);


            lblResultSize.Text = "Small";

        }
        private void rbMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            int addition = Utility.PizzaSizeToInt(PizzaSize.Medium);
            AddToTotal(rbMediumSize.Checked, addition);
            lblResultSize.Text = "Medium";

        }
        private void rbLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            int addition = Utility.PizzaSizeToInt(PizzaSize.Large);
            AddToTotal(rbLargeSize.Checked, addition);
            lblResultSize.Text = "Large";
        }
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            int addition = Utility.PizzaCrustToInt(PizzaCrust.Thin);
            AddToTotal(rbThinCrust.Checked, addition);
            lblResultCrust.Text = "Thin";
        }

        private void rbMediumCrust_CheckedChanged(object sender, EventArgs e)
        {
            int addition = Utility.PizzaCrustToInt(PizzaCrust.Medium);
            AddToTotal(rbMediumCrust.Checked, addition);
            lblResultCrust.Text = "Medium";
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            int addition = Utility.PizzaCrustToInt(PizzaCrust.Thick);
            AddToTotal(rbThickCrust.Checked, addition);
            lblResultCrust.Text = "Thick";
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkExtraCheese.Checked;
            int addition = Utility.ToppingPrice(PizzaToppings.ExtraCheese);
            AddToTotal(isChecked, addition);
            UpdatePizzaToppings(isChecked, PizzaToppings.ExtraCheese);

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkMushrooms.Checked;
            int addition = Utility.ToppingPrice(PizzaToppings.Mushrooms);
            AddToTotal(isChecked, addition);
            UpdatePizzaToppings(isChecked, PizzaToppings.Mushrooms);

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkTomatoes.Checked;
            int addition = Utility.ToppingPrice(PizzaToppings.Tomatoes);
            AddToTotal(isChecked, addition);
            UpdatePizzaToppings(isChecked, PizzaToppings.Tomatoes);

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkOnion.Checked;
            int addition = Utility.ToppingPrice(PizzaToppings.Onion);
            AddToTotal(isChecked, addition);
            UpdatePizzaToppings(isChecked, PizzaToppings.Onion);
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkOlives.Checked;
            int addition = Utility.ToppingPrice(PizzaToppings.Olives);
            AddToTotal(isChecked, addition);
            UpdatePizzaToppings(isChecked, PizzaToppings.Olives);

        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkPeppers.Checked;
            int addition = Utility.ToppingPrice(PizzaToppings.Peppers);
            AddToTotal(chkPeppers.Checked, addition);
            UpdatePizzaToppings(isChecked, PizzaToppings.Peppers);
        }

        private void rbOnTable_CheckedChanged(object sender, EventArgs e)
        {
            this.lblResultEatPlace.Text = "On Table";
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            this.lblResultEatPlace.Text = "Take Out";
        }

        private void btnRestForm_Click(object sender, EventArgs e)
        {
            foreach (var rb in sizeRadioButtons)
            {
                rb.Checked = rb.Text == "Small";
            }
            foreach (var rb in crustRadioButtons)
            {
                rb.Checked = rb.Text == "Thin";
            }
            foreach (var rb in toppingsCheckBoxButtons)
            {
                rb.Checked = false;
            }
            foreach (var rb in eatPlaceRadioButtons)
            {
                rb.Checked = rb.Text == "On Table";

            }
            Utility.SetEnableGroupBoxes(groupBoxes, true);

        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            this.InitLists();
            btnRestForm_Click(sender, e);
            this.numericUpDown1.Maximum = 10;
            this.numericUpDown1.Minimum = 1;
        }

        private void lblOrder_Click(object sender, EventArgs e)
        {
            Utility.SetEnableGroupBoxes(groupBoxes, false);
            MessageBox.Show("Order Done Successfully :) ", "Order Datails", MessageBoxButtons.OK
                           , MessageBoxIcon.Information);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
            int pizzasTotalPrice = pizzaPrice * (int)numericUpDown1.Value;
            this.lblResultTotalOfPizzas.Text = pizzasTotalPrice.ToString()+"$";
        }

        private void lblResultTotal_TextChanged(object sender, EventArgs e)
        {
            bool isDone = int.TryParse
              (this.lblResultTotal.Text.Substring(0, this.lblResultTotal.Text.Length - 1),out pizzaPrice);
            if (!isDone)
                return;
            this.lblResultTotalOfPizzas.Text = pizzaPrice.ToString()+"$";
        }
    }
}
