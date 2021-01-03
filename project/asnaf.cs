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
    public partial class asnaf : Form
    {
        public asnaf()
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
        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void asnaf_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\db1.accdb";
            con_open();
            da = new OleDbDataAdapter("select * from mord", con);
            da.Fill(ds, "mor");
            m_id.DataSource = ds.Tables["mor"];
            m_id.DisplayMember = "m_name";
            m_id.ValueMember = "m_id";

            da = new OleDbDataAdapter("select * from snf", con);
            da.Fill(ds, "sn");

            bs.DataMember = "sn";

            bs.DataSource = ds.Tables["sn"];

            s_id.DataBindings.Add("text", bs, "s_id");
            s_name.DataBindings.Add("text", bs, "s_name");
            s_cm.DataBindings.Add("text", bs, "s_cm");
            s_ab.DataBindings.Add("text", bs, "s_ab");
            s_scm.DataBindings.Add("text", bs, "s_scm");
            s_sab.DataBindings.Add("text", bs, "s_sab");
            m_id.DataBindings.Add("SelectedValue", bs, "m_id");
            pictureBox1.DataBindings.Add("Image", bs, "image", true);
            dataGridView1.DataSource = bs;

            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.Rows[3].DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.Rows[5].DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.Columns[0].HeaderText = "الرقم";
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText = "الكمية";
            dataGridView1.Columns[3].HeaderText = "العبوة";
            dataGridView1.Columns[4].HeaderText = "اسم المورد";
            dataGridView1.Columns[5].HeaderText = "سعر الكرتون";
            dataGridView1.Columns[6].HeaderText = "سعر الحبة";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            OleDbCommand cmd2 = new OleDbCommand("select max(s_id) from snf", con);
            int x = int.Parse(cmd2.ExecuteScalar().ToString());
            x++;
            s_id.Text = x.ToString();
            groupBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.InsertCommand = cb.GetInsertCommand();
            da.Update(ds, "sn");
            groupBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                bs.RemoveCurrent();
                da.DeleteCommand = cb.GetDeleteCommand();
                da.Update(ds, "sn");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            bs.EndEdit();
            da.UpdateCommand = cb.GetUpdateCommand();
            da.Update(ds, "sn");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            groupBox1.Enabled = true;
        }

        private void next_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void back_Click(object sender, EventArgs e)
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

        private void s_sab_Click(object sender, EventArgs e)
        {
            int scm = int.Parse(s_scm.Text);
           // int n2 = int.Parse(s_cm.Text);
            int ab = int.Parse(s_ab.Text);
            int res = scm / ab;
            s_sab.Text = res.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ds.Tables["sn"].Clear();
            da = new OleDbDataAdapter("select * from snf where s_name like '%" + txt_search.Text + "%'", con);
            da.Fill(ds, "sn");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Left += 1;
            if (label8.Left == this.Width)
            {
                label8.Left = 0 - label8.Width;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }
        }
    }
}
