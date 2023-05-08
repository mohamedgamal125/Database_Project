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
    public partial class Customer : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Customer()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-R906GH7;Initial Catalog=SuperMarket;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO CUSTOMER (F_NAME,L_NAME,C_ID,C_ADDRES) VALUES(@F_NAME,@L_NAME,@C_ID,@C_ADDRES)", con);
            cmd.Parameters.Add("@F_NAME", textBox_firstname.Text);
            cmd.Parameters.Add("@L_NAME", textBox_lastname.Text);
            cmd.Parameters.Add("@C_ID", textBoxid.Text);
            cmd.Parameters.Add("@C_ADDRES", textBoxaddress.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer Added Successfully");
            con.Close();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.superMarketDataSet.CUSTOMER);
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.superMarketDataSet.CUSTOMER);

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text == "")
            {
                MessageBox.Show("Please enter the id");
            }
            else
            {
                con = new SqlConnection(@"Data Source=DESKTOP-R906GH7;Initial Catalog=SuperMarket;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("DELETE FROM CUSTOMER WHERE C_ID=" + textBoxid.Text + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Deleted Successfully");
                con.Close();
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            Infomation info = new Infomation();
            info.Show();
            this.Hide();
        }
    }
}
