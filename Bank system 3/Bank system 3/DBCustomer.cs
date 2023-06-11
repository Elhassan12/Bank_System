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
    public partial class DBCustomer : System.Windows.Forms.Form
    {
        DBbankEntities db = new DBbankEntities();
        public DBCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TB_CUSTOMER.ToList();
        }
    }
}
