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
    public partial class UsersApp : Form
    {
        public UsersApp()
        {
            InitializeComponent();
            
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Change_Email change_em = new Change_Email();
            change_em.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chang_Pass chang_pas = new Chang_Pass();
            chang_pas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i=0;i<User_list.users.Count;i++)
            {
                if (User_list.users[i].Password == ChangeUser.Change_Password[0]  && User_list.users[i].Email == ChangeUser.Change_E_mail[0])
                {
                    User_list.users.RemoveAt(i);
                    string delete = "Your account has been deleted.";
                    string delet_tittle = "Congratulations!";
                    MessageBox.Show(delete,delet_tittle);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
