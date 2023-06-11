using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_system_3
{
    public partial class Execute_DB : Form
    {

        DBbankEntities db = new DBbankEntities();
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DBbank;Integrated Security=True");

        public Execute_DB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = textBox1.Text;
            SqlDataAdapter adapter=new SqlDataAdapter(query,con);
            DataSet ds=new DataSet();
            adapter.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count!=0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Execute_DB_Load(object sender, EventArgs e)
        {

        }
    }
}
