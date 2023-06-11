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
    public partial class Statment_a : Form
    {
        DBbankEntities db = new DBbankEntities();
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
        public Statment_a()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select [BRANCH_NUMBER],[ADDRESS] from [dbo].[TB_BRANCH] where  NOT Exists (select *  from [dbo].[TB_CUSTOMER] where [dbo].[TB_BRANCH].[BRANCH_NUMBER]=[dbo].[TB_CUSTOMER].[BRANCH_NUMBER] )", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
            
    }
}
