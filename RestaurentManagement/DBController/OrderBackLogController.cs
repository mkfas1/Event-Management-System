using RestaurentManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentManagement.DBController
{
    public class OrderBackLogController
    {
        public string GetConnection()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=restaurent;Integrated Security=True";
            return connectionString;
        }

        public bool insertOrderBackLog(OrderBackLog orderBackLog)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"insert into OrderBackLog (Price,Discount,Vat,TotalPrice) values('" + orderBackLog.Price + "','" + orderBackLog.Discount + "','" + orderBackLog.Vat + "','" + orderBackLog.TotalPrice + "')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    sqlConnection.Close();
                    return true;
                }
                else
                {
                    sqlConnection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public DataTable getAllOrderBackLog()
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select Id, Price, Discount, Vat, TotalPrice from OrderBackLog";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable getOrderBackLog(string data)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string query = @"select Id,Price,Discount,Vat,TotalPrice from OrderBackLog where Id like  '" + data + "%' or Price like '" + data + "%'  or Discount like  '" + data + "%' or Vat like  '" + data + "%' or Vat TotalPrice  '" + data + "%'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
