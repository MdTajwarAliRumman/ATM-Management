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
    public partial class FastCashOut : Form
    {
        public FastCashOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (balan < 500)
            {
                MessageBox.Show("Balance can not be negative!");
            }
            else
            {

                int newbalance = balan - 500;
                try
                {
                    Con.Open();
                    string query = ("update SignupTbl set Balance='" + newbalance + "' where AccNum='" + acc + "'");
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw completed.");
                    Con.Close();
                    addtransaction2();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
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
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rumman\Documents\ATMData.mdf;Integrated Security=True;Connect Timeout=30");
        string acc = LoginPanel.AccountNumber;
        int balan;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from SignupTbl where AccNum='" + acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label4.Text = "Your balance: Rs. " + dt.Rows[0][0].ToString();
            balan = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void FastCashOut_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        
        private void addtransaction1()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl (AccNum,Type,Amount,TDate) values('" + acc + "','" + TrType + "','" + 100 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction2()
        {
            
            {
                string TrType = "Withdraw";
                try
                {
                    Con.Open();
                    string query = "insert into TransactionTbl (AccNum,Type,Amount,TDate) values('" + acc + "','" + TrType + "','" + 500 + "','" + DateTime.Today.Date.ToString() + "')";
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
        }
        private void addtransaction3()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl (AccNum,Type,Amount,TDate) values('" + acc + "','" + TrType + "','" + 1000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction4()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl (AccNum,Type,Amount,TDate) values('" + acc + "','" + TrType + "','" + 2000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction5()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl (AccNum,Type,Amount,TDate) values('" + acc + "','" + TrType + "','" + 5000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction6()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl (AccNum,Type,Amount,TDate) values('" + acc + "','" + TrType + "','" + 10000 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (balan < 100)
            {
                MessageBox.Show("You do not have sufficiant balance!");
            }
            else
            {

                int newbalance = balan - 100;
                try
                {
                    Con.Open();
                    string query = ("update SignupTbl set Balance='" + newbalance + "' where AccNum='" + acc + "'");
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw completed.");
                    Con.Close();
                    addtransaction1();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (balan < 1000)
            {
                MessageBox.Show("Balance can not be negative!");
            }
            else
            {

                int newbalance = balan - 1000;
                try
                {
                    Con.Open();
                    string query = ("update SignupTbl set Balance='" + newbalance + "' where AccNum='" + acc + "'");
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw completed.");
                    Con.Close();
                    addtransaction3();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (balan < 2000)
            {
                MessageBox.Show("Balance can not be negative!");
            }
            else
            {

                int newbalance = balan - 2000;
                try
                {
                    Con.Open();
                    string query = ("update SignupTbl set Balance='" + newbalance + "' where AccNum='" + acc + "'");
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw completed.");
                    Con.Close();
                    addtransaction4();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (balan < 5000)
            {
                MessageBox.Show("Balance can not be negative!");
            }
            else
            {

                int newbalance = balan - 5000;
                try
                {
                    Con.Open();
                    string query = ("update SignupTbl set Balance='" + newbalance + "' where AccNum='" + acc + "'");
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw completed.");
                    Con.Close();
                    addtransaction5();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (balan < 10000)
            {
                MessageBox.Show("Balance can not be negative!");
            }
            else
            {

                int newbalance = balan - 10000;
                try
                {
                    Con.Open();
                    string query = ("update SignupTbl set Balance='" + newbalance + "' where AccNum='" + acc + "'");
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw completed.");
                    Con.Close();
                    addtransaction6();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
