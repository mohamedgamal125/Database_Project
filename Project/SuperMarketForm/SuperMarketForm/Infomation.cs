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
    public partial class Infomation : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Infomation()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string quary = "SELECT * FROM PRODUCT";
            con = new SqlConnection(@"Data Source=DESKTOP-R906GH7;Initial Catalog=SuperMarket;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand(quary, con);
            da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)//Highest Purchase
        {


        }
    }
}
