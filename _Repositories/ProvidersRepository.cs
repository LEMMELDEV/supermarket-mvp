using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class ProvidersRepository : BaseRepository, IProvidersRepository
    {

        public ProvidersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ProvidersModel providersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Providers VALUES (@document, @firstname, @lastname, @address, @birthday, @phone, @email)";
                command.Parameters.AddWithValue("@document", SqlDbType.NVarChar).Value = providersModel.Document_Number;
                command.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = providersModel.First_Name;
                command.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = providersModel.Last_Name;
                command.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = providersModel.Address;
                command.Parameters.AddWithValue("@birthday", SqlDbType.NVarChar).Value = providersModel.Birthday;
                command.Parameters.AddWithValue("@phone", SqlDbType.NVarChar).Value = providersModel.Phone_Number;
                command.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = providersModel.Email;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProvidersModel providersModel)

        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Providers " +
                                       "SET Providers_Document_Number = @document, " +
                                       "Providers_First_Name = @firstname, " +
                                       "Providers_Last_Name = @lastname, " +
                                       "Providers_Address = @address, " +
                                       "Providers_Birthday = @birthday, " +
                                       "Providers_Phone_Number = @phone, " +
                                       "Providers_Email = @email " +
                                       "WHERE Providers_Id = @id";
                command.Parameters.AddWithValue("@document", SqlDbType.NVarChar).Value = providersModel.Document_Number;
                command.Parameters.AddWithValue("@firstname", SqlDbType.NVarChar).Value = providersModel.First_Name;
                command.Parameters.AddWithValue("@lastname", SqlDbType.NVarChar).Value = providersModel.Last_Name;
                command.Parameters.AddWithValue("@address", SqlDbType.NVarChar).Value = providersModel.Address;
                command.Parameters.AddWithValue("@birthday", SqlDbType.NVarChar).Value = providersModel.Birthday;
                command.Parameters.AddWithValue("@phone", SqlDbType.NVarChar).Value = providersModel.Phone_Number;
                command.Parameters.AddWithValue("@email", SqlDbType.NVarChar).Value = providersModel.Email;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = providersModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Providers WHERE Providers_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProvidersModel> GetAll()
        {
            var providersList = new List<ProvidersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers ORDER BY Providers_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.Id = (int)reader["Providers_Id"];
                        providersModel.Document_Number = reader["Providers_Document_Number"].ToString();
                        providersModel.First_Name = reader["Providers_First_Name"].ToString();
                        providersModel.Last_Name = reader["Providers_Last_Name"].ToString();
                        providersModel.Address = reader["Providers_Address"].ToString();
                        providersModel.Birthday = reader["Providers_Birthday"].ToString();
                        providersModel.Phone_Number = reader["Providers_Phone_Number"].ToString();
                        providersModel.Email = reader["Providers_Email"].ToString();
                        providersList.Add(providersModel);
                    }
                }
            }
            return providersList;
        }

        public IEnumerable<ProvidersModel> GetByValue(string value)
        {
            var providersList = new List<ProvidersModel>();
            int providersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providersName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Providers 
            WHERE Providers_Id=@id OR Providers_First_Name LIKE '%'+@FirstName+'%'
            ORDER BY Providers_Id DESC";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = providersId;
                command.Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value = providersName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.Id = (int)reader["Providers_Id"];
                        providersModel.Document_Number = reader["Providers_Document_Number"].ToString();
                        providersModel.First_Name = reader["Providers_First_Name"].ToString();
                        providersModel.Last_Name = reader["Providers_Last_Name"].ToString();
                        providersModel.Address = reader["Providers_Address"].ToString();
                        providersModel.Birthday = reader["Providers_Birthday"].ToString();
                        providersModel.Phone_Number = reader["Providers_Phone_Number"].ToString();
                        providersModel.Email = reader["Providers_Email"].ToString();
                        providersList.Add(providersModel);
                    }
                }
            }

            return providersList;
        }




    }
}
