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
    public class InventoryController
    {
        public string GetConnection()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=restaurent;Integrated Security=True";
            return connectionString;
        }
        public bool insertInventory(Inventory inventory)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"insert into Raw (Name,Quantity) values('" + inventory.Name + "','" + inventory.Quantity + "')";
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
        public DataTable getAllInventory()
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select * from Raw";
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
        public DataTable getInventory(string data)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select Name,Quantity from Raw where Name like '" + data + "%'  or Quantity like  '" + data + "%'";
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
        public DataTable getAllInventoryForComboBox()
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select Name from Raw";
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
        public List<string> getRawOfName()
        {
            List<string> lst = new List<string>();
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select Name from Raw";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(reader.GetString(0));
                }
                reader.Close();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<int> getRawOfQuantity()
        {
            List<int> lst = new List<int>();
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select Quantity from Raw";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lst.Add(Convert.ToInt32(reader["Quantity"]));
                }
                reader.Close();
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool updateRaw(Inventory inventory)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"update Raw set Quantity='" + inventory.Quantity + "'  where Name = '" + inventory.Name + "' ";
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

        public bool deleteRaw(String data)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"delete from Raw where Name = '" + data + "' ";
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
        public double getQuentity(string name)
        {
            try
            {
                Double quantity = 0;
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select Quantity from Raw where Name = '" + name + "'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //if (sqlDataReader.Read())
                //{
                //    sqlConnection.Close();
                //    return sqlDataReader.GetInt32(2);
                //}
                //else
                //{
                //    sqlConnection.Close();
                //    return 0;
                //}
                quantity = Double.Parse(sqlCommand.ExecuteScalar().ToString());
                return (double)quantity;

            }
            catch (SqlException ex)
            {
                return -1;
            }
        }
    }
}
