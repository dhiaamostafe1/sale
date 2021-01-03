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
    public partial class search : Form
    {
        public search()
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

        private void search_Load(object sender, EventArgs e)
        {
            dion f = new dion();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\db1.accdb";
            con_open();
            da = new OleDbDataAdapter("select * from cust", con);
            da.Fill(ds, "cus");
            txt_search.DataSource = ds.Tables["cus"];
            txt_search.DisplayMember = "c_name";
            txt_search.ValueMember = "c_id";
            da = new OleDbDataAdapter("select c_id,f_ba from fatorh", con);
            da.Fill(ds, "fat");
            bs.DataMember = "fat";
            bs.DataSource = ds.Tables["fat"];
            txt_search.DataBindings.Add("SelectedValue", bs, "c_id");
            dataGridView1.DataSource = bs;
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }
    }
}
