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
    public partial class Chang_Pass : Form
    {
        public string newPassword;
        public Chang_Pass()
        {
            InitializeComponent();
        }

        private void Chang_Pass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var user in User_list.users)
            {
                if (user.Password == ChangeUser.Change_Password[0])
                {

                    user.Password = newPassword;
                    this.Hide();

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            
        }
        private void NewPassword(out string Password)
        {
            var random = new Random();
            string passw = "";
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.,-+/|@";
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
                foreach (char ch in array1)
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
                if (regem > 0 && boyukherf > 0)
                {
                    passbool = false;
                }
                array1 = null;
            }
            Password = passw;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var user in User_list.users)
            {
                if (user.Password == ChangeUser.Change_Password[0])
                {
                    
                        NewPassword(out newPassword);
                        label2.Text = newPassword;
                    
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
