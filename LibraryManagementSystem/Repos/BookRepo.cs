using LibraryManagementSystem2.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2.Repos
{
    public class BookRepo
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
            DataTable dataTable = sqlHelper.ExecuteDataTable("SELECT * FROM Books", CommandType.Text);
            return dataTable;
        }
        public void Insert(string title, string author, string publicationDate, string isbn, string categoryid, string availableCopies, string price)
        {
            SqlHelper sqlHelper = new SqlHelper("");
            // Execute a non-query command
            int rowsAffected = sqlHelper.ExecuteNonQuery
                (@"INSERT INTO Books    INSERT INTO Books
                    (Title, Author, PublicationDate, ISBN, CategoryId, AvailableCopies, Price)
                                      VALUES  (@Title,@ Author, @PublicationDate,@ ISBN, @CategoryId,@ AvailableCopies, @Price) "
            , CommandType.Text,
                new SqlParameter("@Title", title), new SqlParameter("@Author", author), new SqlParameter("@PublicationDate", publicationDate),
                 new SqlParameter("@ISBN", isbn), new SqlParameter("@CategoryId", categoryid), new SqlParameter("@AvailableCopies", availableCopies),
                 new SqlParameter("@Price", isbn));

        }
    }
}
