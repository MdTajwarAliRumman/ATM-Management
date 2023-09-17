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
    public partial class DepositAgain : Form
    {
        public DepositAgain()
        {
            InitializeComponent();
        }
        int oldbalance,newbalance;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from SignupTbl where AccNum='" + acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void DepositAgain_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rumman\Documents\ATMData.mdf;Integrated Security=True;Connect Timeout=30");
        string acc = LoginPanel.AccountNumber;
        private void addtransaction()
        {
            string TrType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl (AccNum,Type,Amount,TDate) values('" + acc + "','" + TrType + "','" + DepositAmount.Text.ToString() + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void button1_Click(object sender, EventArgs e)
        {
            if(DepositAmount.Text == "" || Convert.ToInt32(DepositAmount.Text) <= 0)
            {
                MessageBox.Show("Enter the amount you want to deposit");
            }
            else
            {
                
                newbalance = oldbalance + Convert.ToInt32(DepositAmount.Text);
                try
                {
                    Con.Open();
                    string query = "update SignupTbl set Balance='" + newbalance + "' where AccNum='"+acc+"' ";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your deposit was successful!");
                    Con.Close();
                    addtransaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DepositAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
