using FirstProjectDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstProjectDataLibrary.DataAccess;

namespace FirstProjectDataLibrary.BusinessLogic
{
    public static class UserProcessor
    {
        public static void CreateUser(string name, string lastName, 
            string email, string description, int age, int sexId)
        {
            UserModel data = new UserModel
            {
                Name = name,
                LastName = lastName,
                Email = email,
                Description = description,
                Age = age,
                SexId = sexId
            };

            SqlDataAccess.SaveUser(data);
        }
        public static List<UserModel> LoadUsers()
        {
            string sql = @"SELECT * FROM [dbo].[getUsersData]()";
            return SqlDataAccess.LoadData<UserModel>(sql);
        }
        public static List<SexTypeModel> LoadSexTypes()
        {
            string sql = @"SELECT * FROM [dbo].[getSexTypes]()";
            return SqlDataAccess.LoadData<SexTypeModel>(sql);
        }
        public static void DeleteUser (int id)
        {
            
            SqlDataAccess.DeleteData(id);
        }
    }
}
