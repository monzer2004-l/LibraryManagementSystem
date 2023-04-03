using LibraryManagementSystem2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSystem2
{
    public partial class customerform : Form
    {
        public customerform()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var repo = new CustomerRepo(); 
            dgv.DataSource = repo.LoadData();


        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
              MainForm undo = new MainForm();
            undo.Show();
            this.Hide();
        }       
        

        private void button1_Click(object sender, EventArgs e)
        {
            var repo = new CustomerRepo();
            repo.Insert(txtN.Text, txtE.Text, txtP.Text);
            LoadData();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void customerform_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
