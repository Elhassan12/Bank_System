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
    public partial class Account_Customer : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        public Account_Customer()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.TB_ACCOUNT.Add(new TB_ACCOUNT()
                {
                    SSN = Convert.ToInt32(textBox2.Text),
                    BALANCE = Convert.ToInt32(textBox1.Text),
                    TYPE = comboBox1.SelectedItem.ToString(),


                }
);
                db.SaveChanges();
                MessageBox.Show("Add Successfully");
                ISempty();

            }
            catch
            {
                MessageBox.Show("SSN Not Found");
            }

        }
        public void ISempty()
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }
        private void Account_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
