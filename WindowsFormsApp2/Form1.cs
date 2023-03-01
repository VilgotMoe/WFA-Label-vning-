using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int points = 0;

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Magenta;
            label1.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            points++;
            this.Text = points.ToString();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = "Tack för att du beskökte oss!";
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = "Label 5";
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd1 = random.Next(1, 100);
            int rnd2 = random.Next(1, 100);
            label6.Location = new Point(rnd1, rnd2);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://Google.com");
        }
    }
}
