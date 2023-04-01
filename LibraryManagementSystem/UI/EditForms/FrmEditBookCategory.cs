using LibraryManagementSystem2.Helpers;
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

namespace LibraryManagementSystem2.UI.EditForms
{
    public partial class FrmEditBookCategory : Form
    {
        public FrmEditBookCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper("");
            // Execute a non-query command
            int rowsAffected = sqlHelper.ExecuteNonQuery
                (@"INSERT INTO BookCategories
                (Name, Description) VALUES  (@Name, @Description) ", CommandType.Text,
                new SqlParameter("@Name", txtName.Text), new SqlParameter("@Description", txtDescription.Text));

            //// Execute a scalar command
            //object scalarValue = sqlHelper.ExecuteScalar("SELECT COUNT(*) FROM Users", CommandType.Text);

            //// Execute a reader command
            //SqlDataReader reader = sqlHelper.ExecuteReader("SELECT * FROM Users", CommandType.Text);

            // Execute a data table command
            DataTable dataTable = sqlHelper.ExecuteDataTable("SELECT * FROM BookCategories", CommandType.Text);
            
        }
    }
}
