using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagenv3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pic1_Click(object sender, EventArgs e)
        {

            PictureBox aux = (PictureBox)sender;

            piccentral.Image = aux.Image;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dir = "C:\\Users\\JUAN PABLO\\Desktop\\Imagenes\\";

            pic1.Image = Image.FromFile(dir+"cos1.jpg");
            pic2.Image = Image.FromFile(dir+"cos2.jpg");
            pic3.Image = Image.FromFile(dir+"cos3.jpg");
            pic4.Image = Image.FromFile(dir+"cos4.jpg");
            pic5.Image = Image.FromFile(dir+"cos5.jpg");

        }
    }
}
