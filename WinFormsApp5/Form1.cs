using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.initial;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_text.Text = "你選了第一題";
            pictureBox1.Image= Properties.Resources.no1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_text.Text = "你選了第二題";
            pictureBox1.Image = Properties.Resources.no2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_text.Text = "你選了第三題";
            pictureBox1.Image = Properties.Resources.no3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
