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
    public partial class Bank_Form : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        public Bank_Form()
        {
            InitializeComponent();
        }

        private void Bank_Form_Load(object sender, EventArgs e)
        {

        }
        public void ISempty()
        {
            
            textBox2.Text = "";
            textBox3.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {

            db.TB_BANK.Add(new TB_BANK()
            {
                NAME = textBox2.Text,
                ADDRESS = textBox3.Text
            }
            );
            db.SaveChanges();
            MessageBox.Show("Add Successfully");
            ISempty();
        }
    }
}
