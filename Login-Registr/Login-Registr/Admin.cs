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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = " ";
            foreach (var all_user in User_list.users)
            {
                user+=all_user.Name+" "+all_user.Surname+"  / "+all_user.Email+"\n";
            }
            

            string title = "All users : ";
            MessageBox.Show(user, title);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_delete_users delete_Users = new Admin_delete_users();
            delete_Users.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
