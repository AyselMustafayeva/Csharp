using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gallery
{
    public partial class Form1 : Form
    {
        int left = 10;
        string rootFolderPath = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var pictrlist = new PictureBox();
            var image = new OpenFileDialog();
            image.ShowDialog();
            left += 250;
            pictrlist.Left = left;
            pictrlist.Top = 100;
            pictrlist.Width = 200;
            pictrlist.Height = 200;
            pictrlist.SizeMode = PictureBoxSizeMode.StretchImage;
            pictrlist.ImageLocation = image.FileName;
            var local = $"{rootFolderPath}/Pictures";
            var newName = $"{new Random().Next(0, 1999)}{Path.GetExtension(image.FileName)}";
            File.Copy(image.FileName, $"{local}/{newName}");
            pictrlist.Image = Image.FromFile($"{local}/{newName}");

            this.Controls.Add(pictrlist);

            
        }
    }
}
