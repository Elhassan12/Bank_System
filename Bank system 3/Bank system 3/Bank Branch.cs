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
    public partial class Bank_Branch : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        public Bank_Branch()
        {
            InitializeComponent();
        }

        private void Bank_Branch_Load(object sender, EventArgs e)
        {

        }
        public void ISempty()
        {
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                db.TB_BRANCH.Add(new TB_BRANCH()
                {

                    CODE = Convert.ToInt32(textBox5.Text),
                    ADDRESS = textBox4.Text
                }
                );
                db.SaveChanges();
                MessageBox.Show("Add Successfully");
                ISempty();

            }
            catch
            {
                MessageBox.Show("There is no bank with this code");
            }

        }
    }
}
