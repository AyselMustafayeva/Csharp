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
        internal delegate string For_Admin(List<User> user_List);
        internal string Name;

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
            int index = 0;
            foreach (var all_user in User_list.users)
            {
                index += 1;
                user+= Convert.ToString(index)+". "+ all_user.Name + " " + all_user.Surname + "\nEmail: " + all_user.Email + "\n_______________\n";
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

        private void button4_Click(object sender, EventArgs e)
        {
            For_Admin for_Admin = Look;
            string user_ss = for_Admin(User_list.users);
            string title = "Users";
            MessageBox.Show(user_ss, title);
        }
        public string Look(List<User> user_List)
        {
            string user_s=" ";
            int index = 0;
            foreach(var user in user_List)
            {
                if (Name == user.Name)
                {
                    index += 1;
                    user_s += Convert.ToString(index) + ". " + user.Name + " " + user.Surname +"\nEmail: "+user.Email +"\n_______________\n";
                    
                }
            }
            return user_s;
        }
        public string Sorted(List<User> user_List)
        {
            string date = " ";
            int inndex = 0;
            foreach(var user in user_List)
            {
                inndex += 1;
                date += Convert.ToString(inndex) + ". " + user.Name + " " + user.Surname + "            | Date: " + user.date.ToLongDateString() + "\n_______________\n";
            }
            return date;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Name = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            For_Admin for_Admin2 = Sorted;
            string user_date = for_Admin2(User_list.users);
            string title = "Users";
            MessageBox.Show(user_date, title);
        }
    }
    
}
