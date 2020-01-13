using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FirstProjectDataLibrary.Models;

namespace FirstProjectDataLibrary.DataAccess
{
    public static class SqlDataAccess
    {
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }
        public static void SaveUser(UserModel data)
        {
            var conn = new SqlConnection(GetConnectionString());
            conn.Open();
            var cmd = new SqlCommand("CreateUser", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Name", data.Name));
            cmd.Parameters.Add(new SqlParameter("@LastName", data.LastName));
            cmd.Parameters.Add(new SqlParameter("@Email", data.Email));
            cmd.Parameters.Add(new SqlParameter("@Description", data.Description));
            cmd.Parameters.Add(new SqlParameter("@Age", data.Age));
            cmd.Parameters.Add(new SqlParameter("@SexId", data.SexId));


            cmd.ExecuteNonQuery();
        }
        public static void DeleteData(int Id)
        {
            var conn = new SqlConnection(GetConnectionString());
            conn.Open();
            var cmd = new SqlCommand("DeleteUser", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Id", Id));
            
            cmd.ExecuteNonQuery();
        }
        
        public static string GetConnectionString(string connectionName = "DatabaseForFirstProject")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }
    }
}
