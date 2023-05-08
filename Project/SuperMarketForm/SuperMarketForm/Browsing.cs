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

namespace SuperMarketForm
{
    public partial class Browsing : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Browsing()
        {
            InitializeComponent();
        }

        private void Browsing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketDataSet.PRODUCT' table. You can move, or remove it, as needed.
           // this.pRODUCTTableAdapter.Fill(this.superMarketDataSet.PRODUCT);

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if(textBox_search_byID.Text=="")
            {
                MessageBox.Show("Please entre the ID of the product");
            }
            else
            {
                string quary = "SELECT * FROM PRODUCT WHERE P_ID='" + textBox_search_byID.Text + "'"; ;
                con = new SqlConnection(@"Data Source=DESKTOP-R906GH7;Initial Catalog=SuperMarket;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand(quary, con);
                da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();

            }
        }

    
    }
}
