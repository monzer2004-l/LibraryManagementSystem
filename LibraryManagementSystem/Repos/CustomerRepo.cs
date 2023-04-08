using LibraryManagementSystem2.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2
{
    public class CustomerRepo
    {
        public DataTable LoadData()
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
            DataTable dataTable = sqlHelper.ExecuteDataTable("SELECT * FROM Customers", CommandType.Text);
            return dataTable;
        }
        public void Insert(string name, string email, string phone)
        {
            SqlHelper sqlHelper = new SqlHelper("");
            // Execute a non-query command
            int rowsAffected = sqlHelper.ExecuteNonQuery
                (@"INSERT INTO Customers   (Name, Email, PhoneNumber)VALUES    (@Name, @Email, @PhoneNumber) "
            , CommandType.Text,
                new SqlParameter("@Name", name), new SqlParameter("@Email", email), new SqlParameter("@PhoneNumber", phone));
        }

        public void Update(int id, string name, string email, string phone)
        {
            SqlHelper sqlHelper = new SqlHelper("");
            var fields = new Dictionary<string, object>();
            fields["name"] = name;
            fields["email"] = email.ToLower();
            fields["phone"] = phone;
            sqlHelper.Update("Customerss", fields, $"id={id}");
        }

    }
}
