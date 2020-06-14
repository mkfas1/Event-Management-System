using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using RestaurentManagement.Model;

namespace RestaurentManagement.DBController
{
    public class MenuController
    {
        public string GetConnection()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=restaurent;Integrated Security=True";
            return connectionString;
        }
        public bool insertMenu(OrderMenu orderMenu)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"insert into Items (Name,Price,RM1,RM2,RM3,RM4,Status) values('" + orderMenu.Name + "','" + orderMenu.Price + "','" + orderMenu.Rm1 + "','" + orderMenu.Rm2 + "','" + orderMenu.Rm3 + "','" + orderMenu.Rm4 + "','" + orderMenu.Status + "')";
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
        public DataTable getAllMenu()
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select * from Items";
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
        public DataTable getMenu(string data)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select * from Items where Name like '" + data + "%'  or Price like  '" + data + "%' or Status like  '" + data + "%'";
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
        public DataTable getBreakFast()
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select Id, Name,Price,RM1,RM2, RM3,RM4 from Items where Status like '" + 1 + "%'   ";
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
        public DataTable getLunch()
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string query = @"select Id, Name,Price,RM1,RM2, RM3,RM4 from Items where Status like '" + 2 + "%'   ";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public DataTable getDinner()
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string query = @"select Id, Name,Price,RM1,RM2, RM3,RM4 from Items where Status like '" + 3 + "%' ";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public bool UpdatetMenu(OrderMenu orderMenu)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"update Items set Name = '" + orderMenu.Name + "',Price = '" + orderMenu.Price + "',RM1 = '" + orderMenu.Rm1 + "',RM2 = '" + orderMenu.Rm2 + "',RM3 = '" + orderMenu.Rm3 + "',RM4 = '" + orderMenu.Rm4 + "',Status = '" + orderMenu.Status + "'  where Id = '" + orderMenu.Id + "' ";
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
        public bool deleteMenu(String data)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"delete from Items where Id = '" + data + "' ";
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

    }
}
