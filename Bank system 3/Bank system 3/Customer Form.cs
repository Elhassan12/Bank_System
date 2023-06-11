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
    public partial class Customer_Form : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        public Customer_Form()
        {
            InitializeComponent();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.TB_CUSTOMER.Add(new TB_CUSTOMER()
                {
                    SSN = Convert.ToInt32(textBox5.Text),
                    NAME = textBox2.Text,
                    ADDRESS = textBox3.Text,
                    PHONE = Convert.ToInt32(textBox4.Text),
                    BRANCH_NUMBER = Convert.ToInt32(textBox6.Text),
                    SSN_EMPLOYEE= Convert.ToInt32(textBox7.Text),
                }
);
                db.SaveChanges();
                MessageBox.Show("Add Successfully");
                ISempty();
            }
            catch
            {
                MessageBox.Show("this SSN is Empty or Used before");
             
            }

            

        }
        public void ISempty()
        {
            textBox5.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DBbank;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TB_BRANCH ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
