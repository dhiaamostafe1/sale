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
    public partial class fatorh : Form
    {
        public fatorh()
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

        private void fatorh_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\db1.accdb";
            con_open();
            da = new OleDbDataAdapter("select * from cust", con);
            da.Fill(ds, "cus");  
            c_id.DataSource = ds.Tables["cus"];
            c_id.DisplayMember = "c_name";
            c_id.ValueMember = "c_id";
            da = new OleDbDataAdapter("select * from fatorh", con);
            da.Fill(ds, "fat");
            bs.DataMember = "fat";
            bs.DataSource = ds.Tables["fat"];
            f_id.DataBindings.Add("text", bs, "f_id");
            f_sar.DataBindings.Add("text", bs, "f_sar");
            f_md.DataBindings.Add("text", bs, "f_md");
            f_ba.DataBindings.Add("text", bs, "f_ba");
            f_month.DataBindings.Add("text", bs, "f_month");
            c_id.DataBindings.Add("SelectedValue", bs, "c_id");
            dataGridView1.DataSource = bs;
        }

     
        private void button5_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
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

        private void button11_Click(object sender, EventArgs e)
        {
          
        }

        private void f_ba_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(f_sar.Text);
            int n2 = int.Parse(f_md.Text);
            int n3 = n1 - n2;
            f_ba.Text = n3.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Left += 1;
            if (label7.Left == this.Width)
            {
                label7.Left = 0 - label7.Width;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.InsertCommand = cb.GetInsertCommand();
            da.Update(ds, "fat");
            groupBox1.Enabled = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            bs.AddNew();
            OleDbCommand cmd2 = new OleDbCommand("select max(f_id) from fatorh", con);
            int x = int.Parse(cmd2.ExecuteScalar().ToString());
            x++;
            f_id.Text = x.ToString();
            groupBox1.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                bs.RemoveCurrent();
                da.DeleteCommand = cb.GetDeleteCommand();
                da.Update(ds, "fat");

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.UpdateCommand = cb.GetUpdateCommand();
            da.Update(ds, "fat");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            groupBox1.Enabled = true;
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
             
        }
    }
}
