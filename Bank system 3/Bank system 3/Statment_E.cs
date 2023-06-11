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
    public partial class Statment_E : Form
    {
        DBbankEntities db = new DBbankEntities();
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
        public Statment_E()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select [SSN],[NAME] from[dbo].[TB_CUSTOMER]  where  NOT Exists (select *  from [dbo].[TB_ACCOUNT],[dbo].[TB_LOAN] where [dbo].[TB_CUSTOMER].[SSN]=[dbo].[TB_ACCOUNT].[SSN] AND [dbo].[TB_ACCOUNT].[ACCOUNT_NUMBER]=[dbo].[TB_LOAN].[ACCOUNT_NUMBER])", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
