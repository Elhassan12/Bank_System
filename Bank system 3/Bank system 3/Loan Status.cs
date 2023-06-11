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
    public partial class Loan_Status : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();

        public Loan_Status()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
                con2.Open();
                SqlCommand cmd = new SqlCommand("Update TB_LOAN set [LOAN_STATUS]='" + comboBox1.SelectedItem.ToString() + "' where [LOAN_NUMBER]=" + textBox1.Text + "", con2);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Status Saved");
            }
            catch
            {
                MessageBox.Show("Update Feiled");
            }
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select [dbo].[TB_ACCOUNT].[ACCOUNT_NUMBER],[dbo].[TB_CUSTOMER].[NAME],[dbo].[TB_CUSTOMER].[SSN],[dbo].[TB_ACCOUNT].[BALANCE],[dbo].[TB_ACCOUNT].[TYPE],[dbo].[TB_EMPLOYEE].[SSN_EMPLOYEE],[dbo].[TB_LOAN].[LOAN_AMOUNT],[dbo].[TB_LOAN].[LOAN_TYPE],[dbo].[TB_LOAN].[LOAN_STATUS] from [dbo].[TB_ACCOUNT],[dbo].[TB_LOAN],[dbo].[TB_CUSTOMER],[dbo].[TB_EMPLOYEE] where [dbo].[TB_ACCOUNT].[ACCOUNT_NUMBER]=[dbo].[TB_LOAN].[ACCOUNT_NUMBER] AND [dbo].[TB_ACCOUNT].[SSN]=[dbo].[TB_CUSTOMER].SSN And [dbo].[TB_EMPLOYEE].[SSN_EMPLOYEE]=[dbo].[TB_LOAN].[SSN_EMPLOYEE] AND [dbo].[TB_LOAN].[LOAN_NUMBER]=@SSN", con);
            cmd2.Parameters.AddWithValue("@SSN", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select [dbo].[TB_ACCOUNT].[ACCOUNT_NUMBER],[dbo].[TB_CUSTOMER].[NAME],[dbo].[TB_CUSTOMER].[SSN],[dbo].[TB_ACCOUNT].[BALANCE],[dbo].[TB_ACCOUNT].[TYPE],[dbo].[TB_EMPLOYEE].[SSN_EMPLOYEE],[dbo].[TB_LOAN].[LOAN_AMOUNT],[dbo].[TB_LOAN].[LOAN_TYPE],[dbo].[TB_LOAN].[LOAN_STATUS] from [dbo].[TB_ACCOUNT],[dbo].[TB_LOAN],[dbo].[TB_CUSTOMER],[dbo].[TB_EMPLOYEE] where [dbo].[TB_ACCOUNT].[ACCOUNT_NUMBER]=[dbo].[TB_LOAN].[ACCOUNT_NUMBER] AND [dbo].[TB_ACCOUNT].[SSN]=[dbo].[TB_CUSTOMER].SSN And [dbo].[TB_EMPLOYEE].[SSN_EMPLOYEE]=[dbo].[TB_LOAN].[SSN_EMPLOYEE] AND [dbo].[TB_LOAN].[LOAN_NUMBER]=@SSN", con);
                cmd.Parameters.AddWithValue("@SSN", int.Parse(textBox1.Text));
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


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
