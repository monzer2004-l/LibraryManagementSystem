using LibraryManagementSystem2.Helpers;
using LibraryManagementSystem2.UI.EditForms;
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

namespace LibraryManagementSystem2.Forms
{
    public partial class FrmBooksCategories : Form
    {
        public FrmBooksCategories()
        {
            InitializeComponent();
            LoadData(); 

        }
        public void LoadData()
        {
            SqlHelper sqlHelper = new SqlHelper("");
            // Execute a non-query command
            //int rowsAffected = sqlHelper.ExecuteNonQuery("UPDATE Users SET Name = @Name WHERE Id = @Id", CommandType.Text,
            //    new SqlParameter("@Name", "John"), new SqlParameter("@Id", 1));

            //// Execute a scalar command
            //object scalarValue = sqlHelper.ExecuteScalar("SELECT COUNT(*) FROM Users", CommandType.Text);

            //// Execute a reader command
            //SqlDataReader reader = sqlHelper.ExecuteReader("SELECT * FROM Users", CommandType.Text);

            // Execute a data table command
            DataTable dataTable = sqlHelper.ExecuteDataTable("SELECT * FROM BookCategories", CommandType.Text);
            dgv.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f=new FrmEditBookCategory();
            f.ShowDialog();
        }
    }
}
