using LibraryManagementSystem2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem2.UI.Lists
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var repo = new UsersRepo();
            dgv.DataSource = repo.LoadData();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var repo = new UsersRepo();
            repo.Update(int.Parse(txtId.Text), txtN.Text, txtE.Text, txtP.Text);
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var repo = new UsersRepo();
            repo.Insert(txtN.Text, txtE.Text, txtP.Text);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            
           


        }

        private void btnhome_Click(object sender, EventArgs e)
        {
           MainForm undo = new MainForm();
            undo.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text= dgv.SelectedRows[0].Cells[0].Value.ToString();
            txtN.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtE.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
            txtP.Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
