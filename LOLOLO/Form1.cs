using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOLOLO
{
    public partial class move_step : Form
    {
        bool left, right,top,bottom;
        public move_step()
        {
            InitializeComponent();
        }

        private void move_step_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = true; }
            if(e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.S) { bottom = true; }
            if (e.KeyCode == Keys.D) { right = true; }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void move_step_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = false; }
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.S) { bottom = false; }
            if (e.KeyCode == Keys.D) { right = false; }
        }

        private void move_step_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = pictureBox1.Top.ToString();
            label2.Text = pictureBox1.Left.ToString();
            if (top == true) { pictureBox1.Top -= 8; }
            if (left == true){ pictureBox1.Left -= 8; }
            if (bottom == true) { pictureBox1.Top += 8; }
            if (right == true){pictureBox1.Left += 8;}
            if (pictureBox1.Top > 400) { pictureBox1.Top = 400; }
            if (pictureBox1.Left > 472) { pictureBox1.Left = 472; }
            if (pictureBox1.Top < 12) { pictureBox1.Top = 12; }
            if (pictureBox1.Left < 12) { pictureBox1.Left = 12; }
        }
    }
}
