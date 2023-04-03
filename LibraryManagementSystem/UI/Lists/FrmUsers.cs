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
            var repo = new CustomerRepo();
            dgv.DataSource = repo.LoadData();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
    }
}
