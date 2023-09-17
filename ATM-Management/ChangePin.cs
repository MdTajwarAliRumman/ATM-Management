using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_Management
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rumman\Documents\ATMData.mdf;Integrated Security=True;Connect Timeout=30");
        string acc = LoginPanel.AccountNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter and confirm the new pin.");
            }
            else if(textBox2.Text != textBox1.Text)
            {
                MessageBox.Show("Pin1 and Pin2 are different.");
            }
            else
            {

                //newbalance = oldbalance + Convert.ToInt32(textBox2.Text);
                try
                {
                    Con.Open();
                    string query = ("update SignupTbl set Pin='" + textBox1.Text + "' where AccNum='" + acc + "'");
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your new Pin was successfully updated.");
                    Con.Close();
                    LoginPanel home = new LoginPanel();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }
    }
}
