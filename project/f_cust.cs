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
    public partial class f_cust : Form
    {
        public f_cust()
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
         
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
             
                
        }
        private void f_cust_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\db1.accdb";
            con_open();
            da = new OleDbDataAdapter("select * from snf", con);
            da.Fill(ds, "sn");
            m_name.DataSource = ds.Tables["sn"];
            m_name.DisplayMember = "s_name";
            m_name.ValueMember = "s_id";
            da = new OleDbDataAdapter("select * from cust", con);
            da.Fill(ds, "cus");

            bs.DataMember = "cus";

            bs.DataSource = ds.Tables["cus"];
            txt_id.DataBindings.Add("text", bs, "c_id");
            txt_name.DataBindings.Add("text", bs, "c_name");
            phone.DataBindings.Add("text", bs, "phone");
            txt_mo.DataBindings.Add("text", bs, "c_mo");
            c_gns.DataBindings.Add("text", bs, "c_gns");
            m_name.DataBindings.Add("SelectedValue", bs, "s_id");

            dataGridView1.DataSource = bs;
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.Rows[3].DefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.Rows[5].DefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.Columns[0].HeaderText = "الرقم";
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText ="الهاتف";
            dataGridView1.Columns[3].HeaderText = "الموقع";
            dataGridView1.Columns[4].HeaderText = "الجنس";
            dataGridView1.Columns[5].HeaderText = "رقم الصنف";
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            OleDbCommand cmd2 = new OleDbCommand("select max(c_id) from cust", con);
            int x = int.Parse(cmd2.ExecuteScalar().ToString());
            x++;
            txt_id.Text = x.ToString();
            groupBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.InsertCommand = cb.GetInsertCommand();
            da.Update(ds, "cus");
            groupBox2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                bs.RemoveCurrent();
                da.DeleteCommand = cb.GetDeleteCommand();
                da.Update(ds, "cus");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.UpdateCommand = cb.GetUpdateCommand();
            da.Update(ds, "cus");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            groupBox2.Enabled = true;
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

        private void button10_Click(object sender, EventArgs e)
        {
            ds.Tables["cus"].Clear();
            da = new OleDbDataAdapter("select * from cust where c_name like '%" + txt_search.Text + "%'", con);
            da.Fill(ds, "cus");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ds.Tables["cus"].Clear();
            da = new OleDbDataAdapter("select * from cust", con);
            da.Fill(ds, "cus");
            dataGridView1.DataSource = bs;
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.Rows[3].DefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.Rows[5].DefaultCellStyle.BackColor = Color.Coral;
            dataGridView1.Columns[0].HeaderText = "الرقم";
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText = "الهاتف";
            dataGridView1.Columns[3].HeaderText = "الموقع";
            dataGridView1.Columns[4].HeaderText = "الجنس";
            dataGridView1.Columns[5].HeaderText = "رقم الصنف";
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                ds.Tables["cus"].Clear();
                da = new OleDbDataAdapter("select * from cust", con);
                da.Fill(ds, "cus");
                dataGridView1.DataSource = bs;
                dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Coral;
                dataGridView1.Rows[3].DefaultCellStyle.BackColor = Color.Coral;
                dataGridView1.Rows[5].DefaultCellStyle.BackColor = Color.Coral;
                // dataGridView1.Rows[7].DefaultCellStyle.BackColor = Color.Coral;
                dataGridView1.Columns[0].HeaderText = "الرقم";
                dataGridView1.Columns[1].HeaderText = "الاسم";
                dataGridView1.Columns[2].HeaderText = "الهاتف";
                dataGridView1.Columns[3].HeaderText = "الموقع";
                dataGridView1.Columns[4].HeaderText = "الجنس";
                dataGridView1.Columns[5].HeaderText = "رقم الصنف";
            }
            else
            {
                ds.Tables["cus"].Clear();
                da = new OleDbDataAdapter("select * from cust where c_name like '%" + txt_search.Text + "%'", con);
                da.Fill(ds, "cus");

            }

        }

        private void next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void back_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Left += 1;
            if (label7.Left == this.Width)
            {
                label7.Left = 0 - label7.Width;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        
    }
}
