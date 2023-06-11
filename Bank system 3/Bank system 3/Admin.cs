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
    public partial class Admin : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
        public Admin()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
            SqlDataAdapter cmd = new SqlDataAdapter("select count(*) from TB_ADMIN where PASS = '" + textBox1.Text + "'AND USERNAME='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                new Bank_Form().ShowDialog();
                 
                
            }
            else
            {
                MessageBox.Show("Erorr");
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
