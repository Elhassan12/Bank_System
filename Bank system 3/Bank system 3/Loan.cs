using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_system_3
{
    
    public partial class Loan : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        public Loan()
        {
            InitializeComponent();
        }
        public void ISempty()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedItem = "";
            textBox1.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.TB_LOAN.Add(new TB_LOAN()
                {
                    LOAN_NUMBER = Convert.ToInt32(textBox5.Text),
                    BRANCH_NUMBER = Convert.ToInt32(textBox2.Text),
                    ACCOUNT_NUMBER = Convert.ToInt32(textBox3.Text),
                    LOAN_AMOUNT = Convert.ToInt32(textBox4.Text),
                    LOAN_TYPE = comboBox1.SelectedItem.ToString(),
                    SSN_EMPLOYEE= Convert.ToInt32(textBox1.Text),
                }
);
                db.SaveChanges();
                MessageBox.Show("Your request is in Progress");
                new Loan_Status().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Invalid Credentials");
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
