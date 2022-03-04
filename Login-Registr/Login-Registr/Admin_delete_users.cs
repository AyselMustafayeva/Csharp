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
    public partial class Admin_delete_users : Form
    {
        public string delete_user_name;
        public string delete_user_suname;
        public string delete_user_email;
        public Admin_delete_users()
        {
            InitializeComponent();
        }

        private void Admin_delete_users_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            delete_user_name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            delete_user_suname = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            delete_user_email = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < User_list.users.Count; i++)
            {
                if(User_list.users[i].Name==delete_user_name && User_list.users[i].Surname==delete_user_suname && User_list.users[i].Email == delete_user_email)
                {
                    User_list.users.RemoveAt(i);
                    string msg = "We delete this user. ";
                    MessageBox.Show(msg, "Congratulation");
                }
            }
        }
    }
}
