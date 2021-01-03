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
    public partial class dion : Form
    {
        public dion()
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
        
        private void dion_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\db1.accdb";
            con_open();
          
            da = new OleDbDataAdapter("select * from snf", con);
            da.Fill(ds, "sn");
            s_id.DataSource = ds.Tables["sn"];
            s_id.DisplayMember = "s_name";
            s_id.ValueMember = "s_id";


            da = new OleDbDataAdapter("select * from cust", con);
            da.Fill(ds, "cus");
            c_id.DataSource = ds.Tables["cus"];
            c_id.DisplayMember = "c_name";
            c_id.ValueMember = "c_id";


            da = new OleDbDataAdapter("select * from dion", con);
            da.Fill(ds, "dio");
            bs.DataMember = "dio";
            bs.DataSource = ds.Tables["dio"];
            d_id.DataBindings.Add("text", bs, "d_id");
           
            d_sar.DataBindings.Add("text", bs, "d_sar");
            d_month.DataBindings.Add("text", bs, "d_month");

            s_id.DataBindings.Add("SelectedValue", bs, "s_id");
            c_id.DataBindings.Add("SelectedValue", bs, "c_id");
            dataGridView1.DataSource = bs;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.InsertCommand = cb.GetInsertCommand();
            da.Update(ds, "dio");
            groupBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                bs.RemoveCurrent();
                da.DeleteCommand = cb.GetDeleteCommand();
                da.Update(ds, "dio");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            OleDbCommand cmd2 = new OleDbCommand("select max(d_id) from dion", con);
            int x = int.Parse(cmd2.ExecuteScalar().ToString());
            x++;
            d_id.Text = x.ToString();
            groupBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.UpdateCommand = cb.GetUpdateCommand();
            da.Update(ds, "dio");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            groupBox1.Enabled = true;
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
            ds.Tables["dio"].Clear();
            da = new OleDbDataAdapter("select * from dion", con);
            da.Fill(ds, "dio");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ds.Tables["dio"].Clear();
            da = new OleDbDataAdapter("select * from dion where d_name like '%" + txt_search.Text + "%'", con);
            da.Fill(ds, "dio");
        }

  

        private void d_sar_Click(object sender, EventArgs e)
        {
            search f = new search();
            f.ShowDialog();
        }

        private void next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void back_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Left += 1;
            if (label7.Left == this.Width)
            {
                label7.Left = 0 - label7.Width;
            }
        }
      
    }
}
