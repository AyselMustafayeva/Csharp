using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Registr
{
    public partial class Registr : Form
    {
        internal string NAME;
        internal string SURNAME;
        internal string EMAIL;
        internal string ID;
        internal string PASSWORD;
        public Registr()
        {
            InitializeComponent();
           
            //this.BackColor = Color.Blue;
            //var Nametxt = new Label();
            //Nametxt.Width = 80;
            //Nametxt.Text = "Name : ";
            //Nametxt.Top = 40;
            //Nametxt.Left = this.Width / 2 - 200;
            //Nametxt.ForeColor = Color.Yellow;
            //this.Controls.Add(Nametxt);
            //var UName = new TextBox();
            //UName.Width = 200;
            //UName.Top = 40;
            //UName.Left = this.Width / 2 - 100;
            //UName.ForeColor = Color.Blue;
            //var namebtn = new Button();
            //namebtn.Width = 80;
            //namebtn.Text = "Ok";
            //namebtn.Left = this.Width / 2;
            //namebtn.BackColor = Color.Yellow;
            //namebtn.ForeColor = Color.Blue;
            //namebtn.Top = 40;
            //namebtn.Click += new EventHandler(this.Registration);
            //this.Controls.Add(namebtn);
            //this.Controls.Add(UName);
            //var Surname = new Label();
            //Surname.Width = 80;
            //Surname.Text = "Surname : ";
            //Surname.Top = 70;
            //Surname.Left = this.Width / 2 - 200;
            //Surname.ForeColor = Color.Yellow;
            //this.Controls.Add(Surname);
            //var USurnam = new TextBox();
            //USurnam.Width = 200;
            //USurnam.Top = 70;
            //USurnam.Left = this.Width / 2 - 100;
            //USurnam.ForeColor = Color.Blue;
            //this.Controls.Add(USurnam);
            //var idtxt = new Label();
            //idtxt.Width = 80;
            //idtxt.Text = "ID : ";
            //idtxt.Top = 110;
            //idtxt.Left = this.Width / 2 - 200;
            //idtxt.ForeColor = Color.Yellow;
            //this.Controls.Add(idtxt);
            //var id = new Label();
            //id.Width = 200;
            //id.Top = 140;
            //id.Left = this.Width / 2 - 100;
            //id.ForeColor = Color.Yellow;
            //id.Text = Convert.ToString(rnd.Next(1000, 10000));
            //this.Controls.Add(id);
            //var Email = new Label();
            //Email.Width = 80;
            //Email.Text = "Email : ";
            //Email.Top = 150;
            //Email.Left = this.Width / 2 - 200;
            //Email.ForeColor = Color.Yellow;
            //this.Controls.Add(Email);
            //var UEmail = new TextBox();
            //UEmail.Width = 200;
            //UEmail.Top = 150;
            //UEmail.Left = this.Width / 2 - 100;
            //UEmail.ForeColor = Color.Blue;
            //this.Controls.Add(UEmail);
            //var Password = new Label();
            //Password.Width = 80;
            //Password.Text = "Password : ";
            //Password.Top = 180;
            //Password.Left = this.Width / 2 - 200;
            //Password.ForeColor = Color.Yellow;
            //this.Controls.Add(Password);
            //var UPassword = new Label();
            //UPassword.Width = 200;
            //UPassword.Top = 195;
            //UPassword.Left = this.Width / 2 - 100;
            //UPassword.ForeColor = Color.Yellow;
            //string password;
            //NewPassword(out password);
            //UPassword.Text = password;
            ////NAME = UName.Text;
            ////SURNAME = USurnam.Text;
            //ID = id.Text;
            //PASSWORD = UPassword.Text;
            ////EMAIL = UEmail.Text;
            //this.Controls.Add(UPassword);
            ////var registrbuttn = new Button();
            ////registrbuttn.Width = 80;
            ////registrbuttn.Text = "Registration";
            ////registrbuttn.Left = this.Width / 2;
            ////registrbuttn.BackColor = Color.Yellow;
            ////registrbuttn.ForeColor = Color.Blue;
            ////registrbuttn.Top = 230;
            ////registrbuttn.Click += new EventHandler(this.Registration);
            ////this.Controls.Add(registrbuttn);
        }
        
       

        
        private void NewPassword(out string Password)
        {
            var random = new Random();
            string passw = "";
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,-+/|@";
            int boyukherf = 0;
            int regem = 0;
            Random rnd = new Random();
            bool passbool = true;
            while (passbool)
            {
                for (int i = 0; i < 8; i++)
                {
                    passw += chars[random.Next(0, chars.Length)];
                }
                Char[] array1 = passw.ToCharArray();
                foreach(char ch in array1)
                {
                    if (Char.IsDigit(ch))
                    {
                        regem += 1;
                    }
                    else if (Char.IsUpper(ch))
                    {
                        boyukherf += 1;
                    }
                }
                if(regem>0 && boyukherf > 0)
                {
                    passbool = false;
                }
                array1 = null;
            }
            Password = passw;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NAME = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            ID= Convert.ToString(rnd.Next(1000, 10000));
            label9.Text = ID;
            NewPassword(out PASSWORD);
            label8.Text = PASSWORD;
            User users = new User(ID, NAME, SURNAME, EMAIL, PASSWORD);
            User_list.Add(users);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SURNAME = textBox2.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            EMAIL = textBox3.Text;
        }
    }
    public class User
    {
        internal string ID;
        internal string Name;
        internal string Surname;
        internal string Email;
        internal DateTime date;
        internal string Password;
        public User(string id, string name, string surname, string email, string password)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Email = email;
            date = DateTime.Today;
            Password = password;

        }
    }

    public static class User_list
    {
        public static List<User> users = new List<User>();
        public static void Add(User user)
        {
            users.Add(user);
        }
    }
}
