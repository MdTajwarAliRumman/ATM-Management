using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginPanel log = new LoginPanel();
            log.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show(); 
            this.Show();
        }
        public static string AccountNumber;
        private void Home_Load(object sender, EventArgs e)
        {
            label2.Text = "Account Number: " + LoginPanel.AccountNumber;
            AccountNumber =LoginPanel.AccountNumber;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepositAgain depo=new DepositAgain(); 
            depo.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin pin=new ChangePin();
            pin.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Withdraw wd=new Withdraw();
            wd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FastCashOut fcash=new FastCashOut();
            fcash.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaction tx=new Transaction();
            tx.Show();
            this.Hide();
        }
    }
}
