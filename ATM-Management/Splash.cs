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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
     
        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            {
                starting +=1;
               progressBar.Value = starting;
                percentage.Text = "" + starting;
                if(progressBar.Value == 10)
                {
                    progressBar.Value = 0;
                    timer1.Stop();
                    LoginPanel log = new LoginPanel();
                    this.Hide();
                    log.Show();

                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
