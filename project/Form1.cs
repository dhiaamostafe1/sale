using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f_mord frm = new f_mord();
            frm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f_cust frm = new f_cust();
            frm.Show();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dion frm = new dion();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fatorh frm = new fatorh();
            frm.Show();
            
        }
       
        private void tr_Scroll(object sender, EventArgs e)
        {
             
        }

        private void tg_Scroll(object sender, EventArgs e)
        {
             
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
             
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fatorh frm = new fatorh();
            f_cust fc = new f_cust();
            f_mord fm = new f_mord();
            dion d = new dion();
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog1.Color;
            frm.BackColor = colorDialog1.Color;
            fc.BackColor = colorDialog1.Color;
            fm.BackColor = colorDialog1.Color;
            d.BackColor = colorDialog1.Color;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            asnaf sn = new asnaf();
            sn.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += 1;
            if (label1.Left == this.Width)
            {
                label1.Left = 0 - label1.Width;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void الToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
