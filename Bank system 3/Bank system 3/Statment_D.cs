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
    public partial class Statment_D : Form
    {
        DBbankEntities db = new DBbankEntities();
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
        public Statment_D()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select top 1 c.SSN,c.[NAME],c.[PHONE],count(*) as num_of_loans from  [dbo].[TB_CUSTOMER] c join [dbo].[TB_ACCOUNT] l on c.SSN= l.SSN join [dbo].[TB_LOAN] n on n.ACCOUNT_NUMBER=l.ACCOUNT_NUMBER Group by c.SSN ,c.NAME,c.PHONE order by count(*) desc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
