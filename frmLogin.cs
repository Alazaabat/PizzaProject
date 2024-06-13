using PizzaProject.Models;
using PizzaProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
       
           
        }
        private void Login(Tuple<frmLogin,User> args)
        {
            this.Hide();
            Form pizzaOrderForm = new frmPizzaOrder();
            pizzaOrderForm.Tag = args;
            pizzaOrderForm.Show();
            
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void lblPasswordForget_MouseEnter(object sender, EventArgs e)
        {
            this.lblPasswordForget.ForeColor = Color.DarkRed;
        }

        private void lblPasswordForget_MouseLeave(object sender, EventArgs e)
        {
            this.lblPasswordForget.ForeColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           User user=new User(this.txtUsername.Text,this.txtPassword.Text);
            bool canLogin = LogginChecker.GetChecker().Check(user);
            if(canLogin is false)
            {
                MessageBox.Show("Email or Password is wrong", "Cannot Login !!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Login(new Tuple<frmLogin,User>(this,user));
            }
        }
    }
}
