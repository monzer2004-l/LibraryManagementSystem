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



namespace LibraryManagementSystem2
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

        private void Librarance_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repo = new UsersRepo();
             repo.Insert(txtName.Text,txtEmail.Text,txtPassword.Text);
            LoadData();

        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
