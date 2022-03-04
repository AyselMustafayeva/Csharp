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
    public partial class Change_Email : Form
    {
        public string newEmail;
        public Change_Email()
        {
            InitializeComponent();
        }

        private void Change_Email_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newEmail = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var user in User_list.users)
            {
                if (user.Email == ChangeUser.Change_E_mail[0])
                {
                    if (newEmail != null)
                    {
                        user.Email = newEmail;
                        this.Hide();
                    }
                }
            }
        }
    }
}
