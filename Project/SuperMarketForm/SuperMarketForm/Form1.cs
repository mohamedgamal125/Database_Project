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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_password.Clear();
            textBox_username.Clear();
            
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please enter empty cells");
               
            }
            else
            {
                if (comboBox_role.SelectedItem.ToString() == "Admin")
                {
                    if (textBox_username.Text == "Admin" && textBox_password.Text == "Admin123")
                    {
                        Global G = new Global();
                        G.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("If you are Admin, Please Enter the corret Id and Password", "Miss Id");
                    }
                }
                else
                {
                    if (textBox_username.Text == "Mohamed" && textBox_password.Text == textBox_username.Text+"123")
                    {    Global2 global = new Global2();
                         global.Show();
                         this.Hide();
                    }
                }
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}