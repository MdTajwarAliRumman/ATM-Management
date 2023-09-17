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
    public partial class ManageAccountT : Form
    {
        public ManageAccountT()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rumman\Documents\ATMData.mdf;Integrated Security=True;Connect Timeout=30");
            int tal = 0;
            if(textBox1.Text==""|| textBox2.Text==""|| textBox3.Text==""|| textBox7.Text==""|| textBox5.Text==""|| textBox6.Text==""|| textBox4.Text=="")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    Con.Open();
                    string query = "insert into SignupTbl(AccNum,Fname,Lname,DOB,Address,Education,Occupation,Phone,Pin) values('"+ textBox1.Text.ToString()+ "','"+ textBox2.Text.ToString() + "','"+ textBox3.Text.ToString() + "','"+DOBT.Value.Date+ "','"+ textBox7.Text.ToString() + "','"+ EducationT.SelectedItem.ToString()+ "','"+ textBox5.Text.ToString() + "','"+ textBox6.Text.ToString() + "','"+ textBox4.Text.ToString()+ "')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                   
                    Con.Close();
                        
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            LoginPanel log = new LoginPanel();
            log.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
