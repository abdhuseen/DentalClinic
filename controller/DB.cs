using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.controller
{
   public class DB
    {
        static SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DentalClinic;Integrated Security=True");
        static SqlCommand command = new SqlCommand();
        public DB()
        {
            
        }

        public static void nonQuery(string query)
        {
          
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            if (sqlConnection.State == ConnectionState.Open)
            {
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
               command.ExecuteNonQuery();
                sqlConnection.Close();
            }

         
        }

        public static SqlDataReader query(string query)
        {
            SqlDataReader result=null;
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            if (sqlConnection.State == ConnectionState.Open)
            {
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                result = command.ExecuteReader();
               
            }
            return result;
        }

        public static void close()
        {
            DB.sqlConnection.Close();
        }

        public static SqlCommand GetCommand()
        {
            return command;
        }

      
    }
}
