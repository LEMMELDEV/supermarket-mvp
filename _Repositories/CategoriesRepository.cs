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
    internal class CategoriesRepository : BaseRepository, ICategoriesRepository
    {

        public CategoriesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CategoriesModel categoriesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categories VALUES (@name, @description)";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                command.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = categoriesModel.Description;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriesModel categoriesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Categories " +
                                       "SET Categories_Name = @name, " +
                                       "Categories_Description = @description " +
                                       "WHERE Categories_Id = @id";
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                command.Parameters.AddWithValue("@description", SqlDbType.NVarChar).Value = categoriesModel.Description;
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = categoriesModel.Id;
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
                command.CommandText = "DELETE FROM Categories WHERE Categories_Id = @id";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            var categoriesList = new List<CategoriesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categories ORDER BY Categories_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriesModel = new CategoriesModel();
                        categoriesModel.Id = (int)reader["Categories_Id"];
                        categoriesModel.Name = reader["Categories_Name"].ToString();
                        categoriesModel.Description = reader["Categories_Description"].ToString();
                        categoriesList.Add(categoriesModel);
                    }
                }
            }
            return categoriesList;
        }

        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categoriesList = new List<CategoriesModel>();
            int categoriesId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoriesName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories 
                    WHERE Categories_Id=@id OR Categories_Name LIKE '%'+@name+'%'
                    ORDER BY Categories_Id DESC";
                command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = categoriesId;
                command.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = categoriesName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriesModel = new CategoriesModel();
                        categoriesModel.Id = (int)reader["Categories_Id"];
                        categoriesModel.Name = reader["Categories_Name"].ToString();
                        categoriesModel.Description = reader["Categories_Description"].ToString();
                        categoriesList.Add(categoriesModel);
                    }
                }
            }

            return categoriesList;
        }



    }
}
