using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem2
{
    public partial class SplachForm : Form
    {
        public SplachForm()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            onehundred.Text="%"+startpoint;
            if(Myprogress.Value==100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                LoginForm login=new LoginForm();
                login.Show();
                this.Hide();

            }
        }

        private void SplachForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }
    }
}
