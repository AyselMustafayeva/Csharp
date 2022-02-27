using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Load;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 1;
            int top = 0;
            for(int i = 0; i < 8; i++)
            {
                if (n % 2 != 0)
                {
                    Button1(top);
                }
                else
                {
                    Button2(top);
                }
                top += 80;
                n += 1;
            }

        }

        private void Button1(int n)
        {
            
            int left = 10;
            for (int i = 0; i < 8; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Width = 80;
                button.Height = 80;
                button.Top = n;
                this.Controls.Add(button);
                left += button.Width+2;
                if (i % 2 != 0)
                {
                    button.BackColor = Color.White;
                }
                else
                {
                    button.BackColor = Color.Black;
                }
            }
        }
        private void Button2(int n)
        {
            int left = 10;
            for (int i = 0; i < 8; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Width = 80;
                button.Height = 80;
                button.Top = n;
                this.Controls.Add(button);
                left += button.Width + 2;
                if (i % 2 != 0)
                {
                    button.BackColor = Color.Black;
                }
                else
                {
                    button.BackColor = Color.White;
                }
            }
        }
    }
}
