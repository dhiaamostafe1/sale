using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class f_mord : Form
    {
        public f_mord()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        void con_open()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void f_mord_Load(object sender, EventArgs e)
        {
            con.ConnectionString ="Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\db1.accdb";
            con_open();
            da = new OleDbDataAdapter("select * from mord", con);
            da.Fill(ds, "mor");
            bs.DataMember = "mor";
            bs.DataSource = ds.Tables["mor"];
            txt_id.DataBindings.Add("text", bs, "m_id");
            txt_name.DataBindings.Add("text", bs, "m_name");
            phone.DataBindings.Add("text", bs, "phone");
            pictureBox1.DataBindings.Add("Image", bs, "image", true);

            dataGridView1.DataSource = bs;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            OleDbCommand cmd2 = new OleDbCommand("select max(m_id) from mord", con);
            int x = int.Parse(cmd2.ExecuteScalar().ToString());
            
            txt_id.Text = x.ToString()+5;
            groupBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.UpdateCommand = cb.GetUpdateCommand();
            da.Update(ds, "mor");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد الحذف", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                bs.RemoveCurrent();
                da.DeleteCommand = cb.GetDeleteCommand();
                da.Update(ds, "mor");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.InsertCommand = cb.GetInsertCommand();
            da.Update(ds, "mor");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
        }

        private void next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void back_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            OleDbCommand cmd2 = new OleDbCommand("select max(m_id) from mord", con);
            int x = int.Parse(cmd2.ExecuteScalar().ToString());
            x++;
            txt_id.Text = x.ToString();
            groupBox1.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.UpdateCommand = cb.GetUpdateCommand();
            da.Update(ds, "mor");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                bs.RemoveCurrent();
                da.DeleteCommand = cb.GetDeleteCommand();
                da.Update(ds, "mor");

            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            ds.Tables["mor"].Clear();
            da = new OleDbDataAdapter("select * from mord where m_name like '%" + txt_search.Text + "%'", con);
            da.Fill(ds, "mor");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.InsertCommand = cb.GetInsertCommand();
            da.Update(ds, "mor");
            groupBox1.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            groupBox1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Left += 1;
            if (label7.Left == this.Width)
            {
                label7.Left = 0 - label7.Width;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }
        }
    }
}
