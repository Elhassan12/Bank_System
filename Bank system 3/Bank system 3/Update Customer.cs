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
    public partial class Update_Customer : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=bankDB;Integrated Security=True");
        public Update_Customer()
        {
            InitializeComponent();
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Customer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("update TB_CUSTOMER set NAME='" + textBox2.Text + "',ADDRESS='" + textBox3.Text + "',PHONE='" + textBox4.Text + "',[BRANCH_NUMBER]='" + textBox6.Text + "' where SSN=" + textBox1.Text + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("update succesful");
               
            }
            catch
            {
                MessageBox.Show("Update Failed");

            }
            
        }
        public void ISempty()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from TB_CUSTOMER where SSN=@SSN" , con);
                cmd.Parameters.AddWithValue("@SSN", int.Parse(textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("SSN Not found or Not filled");
            }
        }
    }
}
