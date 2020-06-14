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
    public class PersonController
    {
        public string GetConnection()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=restaurent;Integrated Security=True";
            return connectionString;
        }

        public bool insertPerson(Person person)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"insert into Person (Name,Address,Password,Status) values('" + person.Name + "','" + person.Address + "','" + person.Password + "','" + person.Status + "')";
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

        public int loginPerson(string id, string password)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select * from Person where Id = '" + id + "' and Password = '" + password + "'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    return sqlDataReader.GetInt32(4);
                }
                else
                {
                    sqlConnection.Close();
                    return -1;
                }

            }
            catch (SqlException ex)
            {
                return -1;
            }
        }

        public DataTable getAllPerson()
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"select Id, Name, Address, Password, Status from Person";
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

        public DataTable getPerson(string data)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                string query = @"select Id,Name,Address,Status from Person where Id like  '" + data + "%' or Name like '" + data + "%'  or Address like  '" + data + "%' or Status like  '" + data + "%'";
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
        public bool updatePerson(Person person)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"update Person set Name='" + person.Name + "',Address='" + person.Address + "',Password='" + person.Password + "',Status='" + person.Status + "' where ID = '"+person.Id+"' ";
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
        public bool deletePerson(String data)
        {
            try
            {
                string connectionString = GetConnection();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                string query = @"delete from Person where ID = '" + data + "' ";
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
