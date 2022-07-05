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

        private Hero Hero = new Hero();
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
            pictureBox6.Image = Properties.Resources.neighbor2;
            pictureBox7.Image = Properties.Resources.ciller;
            pictureBox8.Image = Properties.Resources.ciller;
            pictureBox9.Image = Properties.Resources.neighbor2;
            pictureBox11.Image = Properties.Resources.ciller;
            label1.Visible = false;
            label2.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox10.Refresh();
            Hero.y = 250;
            Graphics g = pictureBox10.CreateGraphics();
            Hero.Draw(g);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox10.Refresh();
            Hero.x = 20;
            Graphics g = pictureBox10.CreateGraphics();
            Hero.Draw(g);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox10.Refresh();
            Hero.y = 20;
            Graphics g = pictureBox10.CreateGraphics();
            Hero.Draw(g);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox10.Refresh();
            Hero.x = 260;
            Graphics g = pictureBox10.CreateGraphics();
            Hero.Draw(g);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox10.CreateGraphics();
            Hero.Draw(g);
        }
    }
    internal class Hero
    {
        public int x, y;
        public int width, height;
        public Color bColor, cColor;
        public Hero()
        {
            x = 260;
            y = 510;
            width = height = 30;
            cColor = Color.Black;
            bColor = Color.White;
        }

        public Hero(int xx, int yy, int w, int hm, Color cc, Color bc)
        {
            x = xx;
            y = yy;
            width = w;
            height = hm;
            cColor = cc;
            bColor = bc;
        }
        public void Draw(Graphics gr)
        {
            Pen pn = new Pen(cColor, 5);
            Brush br = new SolidBrush(bColor);

            gr.FillEllipse(br, x, y, width, height);
            gr.DrawEllipse(pn, x, y, width, height);
        }

        
    }
    
}
