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
  
    public partial class Product : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Product()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-R906GH7;Initial Catalog=SuperMarket;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO PRODUCT (P_ID,P_NAME,P_PRICE,TYPE) VALUES(@P_ID,@P_NAME,@P_PRICE,@TYPE)",con);
            cmd.Parameters.Add("@P_ID", textBox_id.Text);
            cmd.Parameters.Add("@P_NAME", textBox_name.Text);
            cmd.Parameters.Add("@P_PRICE", textBox_price.Text);
            cmd.Parameters.Add("@TYPE", textBox_type.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Added Successfully");
            con.Close();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superMarketDataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.superMarketDataSet.PRODUCT);

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.pRODUCTTableAdapter.Fill(this.superMarketDataSet.PRODUCT);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text=="")
            {
                MessageBox.Show("Please enter the id");
            }
            else
            {
                con = new SqlConnection(@"Data Source=DESKTOP-R906GH7;Initial Catalog=SuperMarket;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("DELETE FROM PRODUCT WHERE P_ID="+textBox_id.Text+"",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Deleted Successfully");
                con.Close();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text=="" || textBox_name.Text=="" || textBox_price.Text=="" || textBox_type.Text=="" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string quary= "UPDATE Product SET P_NAME='" + textBox_name.Text + "',P_PRICE=" + textBox_price.Text + ",TYPE='" +textBox_type.Text + "'WHERE P_ID=" + textBox_id.Text + "";
                con = new SqlConnection(@"Data Source=DESKTOP-R906GH7;Initial Catalog=SuperMarket;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand(quary, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Updated Successfully");
                con.Close();
            }
        }
    }
}
