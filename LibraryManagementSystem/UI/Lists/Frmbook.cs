using LibraryManagementSystem2.Repos;
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
    public partial class Frmbook : Form
    {
        public Frmbook()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var repo = new BookRepo();
            dgv.DataSource = repo.LoadData();


        }
        private void BookTbl_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repo = new BookRepo();
            repo.Insert(txtBookName.Text, txtAuthor.Text, txtPublisher.Text,txtISBN.Text,txtCategoryId.Text,txtAvailableCopies.Text,txtPrice.Text);
            LoadData();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            MainForm undo = new MainForm();
            undo.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
    
}
