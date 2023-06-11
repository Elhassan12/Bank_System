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
    public partial class Statment_F : Form
    {
        DBbankEntities db = new DBbankEntities();
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
        public Statment_F()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select [dbo].[TB_CUSTOMER].NAME,[dbo].[TB_CUSTOMER].SSN,[dbo].[TB_CUSTOMER].PHONE,[dbo].[TB_CUSTOMER].ADDRESS,[dbo].[TB_CUSTOMER].BRANCH_NUMBER,count([dbo].[TB_LOAN].ACCOUNT_NUMBER) as no_of_deals, [dbo].[TB_LOAN].[SSN_EMPLOYEE] from [dbo].[TB_LOAN] ,[dbo].[TB_CUSTOMER],[dbo].[TB_ACCOUNT] where [dbo].[TB_LOAN].ACCOUNT_NUMBER=[dbo].[TB_ACCOUNT].ACCOUNT_NUMBER and [dbo].[TB_CUSTOMER].SSN=[dbo].[TB_ACCOUNT].SSN group by [dbo].[TB_CUSTOMER].NAME,[dbo].[TB_CUSTOMER].SSN,[dbo].[TB_CUSTOMER].PHONE,[dbo].[TB_CUSTOMER].ADDRESS,[dbo].[TB_CUSTOMER].BRANCH_NUMBER,[dbo].[TB_LOAN].ACCOUNT_NUMBER,[dbo].[TB_LOAN].[SSN_EMPLOYEE],[dbo].[TB_CUSTOMER].NAME ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
