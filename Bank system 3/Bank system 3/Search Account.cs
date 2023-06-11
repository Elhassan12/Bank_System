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
    public partial class Search_Account : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();

        public Search_Account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select [dbo].[TB_ACCOUNT].[ACCOUNT_NUMBER],[dbo].[TB_CUSTOMER].[SSN],BALANCE,TYPE,TB_CUSTOMER.NAME,TB_CUSTOMER.ADDRESS,[dbo].[TB_CUSTOMER].[BRANCH_NUMBER] from TB_ACCOUNT,TB_CUSTOMER where TB_ACCOUNT.[SSN] = TB_CUSTOMER.SSN And TB_CUSTOMER.SSN=@SSN", con);
                cmd.Parameters.AddWithValue("@SSN", int.Parse(textBox2.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch 
            {
                MessageBox.Show("erorr");
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}


