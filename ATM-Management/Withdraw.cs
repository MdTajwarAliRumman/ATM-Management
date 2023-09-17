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

namespace ATM_Management
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rumman\Documents\ATMData.mdf;Integrated Security=True;Connect Timeout=30");
        string acc = LoginPanel.AccountNumber;
        int balan;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from SignupTbl where AccNum='" + acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label4.Text = "Rs. " + dt.Rows[0][0].ToString();
            balan = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void addtransaction()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl (AccNum,Type,Amount,TDate) values('" + acc + "','" + TrType + "','" + textBox2.Text.ToString() + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Account Created Successfully!");


                Con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        int newbalance;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else if(Convert.ToInt32(textBox2.Text) <= 0)
            {
                MessageBox.Show("Please enter valid amount");
            }
            else if (Convert.ToInt32(textBox2.Text) > balan)
            {
                MessageBox.Show("Warning!You have insufficient balance.Please insert appropriate amount.");
            }
            else
            {
                try
                {
                    newbalance = balan - Convert.ToInt32(textBox2.Text);
                    try
                    {
                        Con.Open();
                        string query = ("update SignupTbl set Balance='" + newbalance + "' where AccNum='" + acc + "'");
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Withdraw completed.");
                        Con.Close();
                        addtransaction();
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
