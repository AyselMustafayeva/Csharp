using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            var emailtxt = new Label();
            emailtxt.ForeColor = Color.Red;
            emailtxt.Width = 60;
            emailtxt.Left = this.Width / 2-2* emailtxt.Width;
            emailtxt.Top = this.Height/2-100;
            emailtxt.Text = "Email : ";
            var UEmail = new TextBox();
            UEmail.ForeColor = Color.Red;
            UEmail.Width = 220;
            UEmail.Left = (this.Width / 2)-emailtxt.Width;
            UEmail.Top = this.Height / 2 - 100;
            this.Controls.Add(emailtxt);
            this.Controls.Add(UEmail);
            var Passtxt = new Label();
            Passtxt.ForeColor = Color.Red;
            Passtxt.Width = 60;
            Passtxt.Left = this.Width / 2 - 2 * emailtxt.Width;
            Passtxt.Top = this.Height / 2 - 60;
            Passtxt.Text = "Password : ";
            var UPassword = new TextBox();
            UPassword.ForeColor = Color.Red;
            UPassword.Width = 220;
            UPassword.Left = (this.Width / 2) - emailtxt.Width;
            UPassword.Top = this.Height / 2 - 60;
            this.Controls.Add(UPassword);
            this.Controls.Add(Passtxt);
            var loginbtn = new Button();
            loginbtn.Width = 90;
            loginbtn.Top = this.Height / 2;
            loginbtn.Left = this.Width / 2 - 50 ;
            loginbtn.Text = "Login";
            loginbtn.BackColor = Color.Red;
            loginbtn.ForeColor = Color.Black;
            this.Controls.Add(loginbtn);
            var registrbtn = new Button();
            registrbtn.Width = 90;
            registrbtn.Top = this.Height / 2;
            registrbtn.Left = this.Width / 2+50;
            registrbtn.Text = "Registration";
            registrbtn.BackColor = Color.Red;
            registrbtn.ForeColor = Color.Black;
            registrbtn.Click += new EventHandler(this.ShowRegistr); 
            this.Controls.Add(registrbtn);


        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            System.
        }
    }
}
