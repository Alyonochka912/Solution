using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_quest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.hero1;
            pictureBox2.Image = Properties.Resources.hero2;
            pictureBox3.Image = Properties.Resources.hero3;
            pictureBox4.Image = Properties.Resources.hero4;
            pictureBox5.Image = Properties.Resources.hero5;
        }
    }
}
