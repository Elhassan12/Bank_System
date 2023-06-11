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
    public partial class Form1 : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bank_Form().ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Customer_Form().ShowDialog();
        }

        private void updateCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Update_Customer().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBankToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Admin().ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addBranchBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Admin2().ShowDialog();
        }
        private void addEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Employee_form().ShowDialog();
        }



        private void addLoanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Loan().ShowDialog();
        }

        private void showLoanInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Loan_INFO().ShowDialog();
        }

        private void loanStatuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Loan_Status().ShowDialog();
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Account_Customer().ShowDialog();
        }

        private void searchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Search_Account().ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DBCustomer().ShowDialog();  
        }

        private void allEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LIst_Employee().ShowDialog();
        }

        private void dBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Statment_a().ShowDialog();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Statment_B().ShowDialog();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Statment_E().ShowDialog();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Statment_C().ShowDialog();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Statment_D().ShowDialog();
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Statment_F().ShowDialog();
        }
    }
}
