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
    public partial class Employee_form : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        public Employee_form()
        {
            InitializeComponent();
        }
        public void ISempty()
        {
            textBox5.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedItem.ToString();
            textBox6.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.TB_EMPLOYEE.Add(new TB_EMPLOYEE()
                {
                    SSN_EMPLOYEE = Convert.ToInt32(textBox5.Text),
                    NAME = textBox2.Text,
                    ADDRESS = textBox3.Text,
                    PHONE = Convert.ToInt32(textBox4.Text),
                    POSTION_= comboBox1.SelectedItem.ToString(),
                    BRANCH_NUMBER = Convert.ToInt32(textBox6.Text)
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TB_BRANCH.ToList();
        }
    }
}
