using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketForm
{
    public partial class Global2 : Form
    {
        public Global2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Browsing B = new Browsing();
            B.Show();
            this.Hide();
        }

        private void button_customer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            
        }
    }
}
