﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagementSystem2.Helpers
{
    public class UsersRepo
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
            DataTable dt = sqlHelper.ExecuteDataTable("SELECT * FROM Users", CommandType.Text);
            return dt;
        }
        public void Insert(string name,string email,string password)
        {
            SqlHelper sqlHelper = new SqlHelper("");
           
            // Execute a non-query command
            int rowsAffected = sqlHelper.ExecuteNonQuery
                (@"INSERT INTO Users    (Name, Email, Password)VALUES    (@Name, @Email, @Password) "
            , CommandType.Text,
                new SqlParameter("@Name",name), new SqlParameter("@Email", email.ToLower()
                ),new SqlParameter("@password",StringEncryptor.Encrypt(email.ToLower(), password))) ;

        }
        public void Update(int id, string name, string email, string password)
        {
            SqlHelper sqlHelper = new SqlHelper("");
            var fields = new Dictionary<string, object>();
            fields["name"] = name;
            fields["email"] = email.ToLower();
            fields["password"] = StringEncryptor.Encrypt(email.ToLower(), password);
            sqlHelper.Update("Users", fields, $"id={id}");
        }

       
    }
}
