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
    public partial class Loan_INFO : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        public Loan_INFO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select [dbo].[TB_CUSTOMER].SSN,[dbo].[TB_CUSTOMER].NAME [CUSTOMER NAME],[dbo].[TB_ACCOUNT].[ACCOUNT_NUMBER],[dbo].[TB_LOAN].[LOAN_NUMBER],[dbo].[TB_LOAN].[ACCOUNT_NUMBER],[dbo].[TB_LOAN].[LOAN_TYPE],[dbo].[TB_LOAN].[LOAN_AMOUNT],[dbo].[TB_LOAN].[SSN_EMPLOYEE],[dbo].[TB_EMPLOYEE].[NAME] AS [EMPLOYEE NAME] from [dbo].[TB_CUSTOMER],[dbo].[TB_ACCOUNT],[dbo].[TB_LOAN],[dbo].[TB_EMPLOYEE]where [TB_LOAN].[ACCOUNT_NUMBER]=[TB_ACCOUNT].[ACCOUNT_NUMBER] AND [dbo].[TB_ACCOUNT].[SSN] =[dbo].[TB_CUSTOMER].SSN And [dbo].[TB_LOAN].[SSN_EMPLOYEE]=[dbo].[TB_EMPLOYEE].[SSN_EMPLOYEE]  AND [dbo].[TB_CUSTOMER].SSN =@SSN", con);
                cmd.Parameters.AddWithValue("@SSN", int.Parse(textBox2.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("error");
            }

        }
    }
}
