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
    public partial class Admin2 : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();

        public Admin2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
            SqlDataAdapter cmd = new SqlDataAdapter("select count(*) from TB_ADMIN where PASS = '" + textBox1.Text + "'AND USERNAME='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new Bank_Branch().ShowDialog();


            }
            else
            {
                MessageBox.Show("Erorr");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
