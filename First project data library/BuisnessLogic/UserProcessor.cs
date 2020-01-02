using FirstProjectDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstProjectDataLibrary.DataAccess;

namespace FirstProjectDataLibrary.BuisnessLogic
{
    public static class UserProcessor
    {
        public static int CreateUser(string name, string lastName, 
            string email, string description, int age)
        {
            UserModel data = new UserModel
            {
                Name = name,
                LastName = lastName,
                Email = email,
                Description = description,
                Age = age
            };
            string sql = @"insert into dbo.UserData (Name, LastName, Email, Description, Age)
                          values (@Name, @LastName, @Email, @Description, @Age);";

            return SqlDataAccess.SaveData(sql, data);
        }
        public static List<UserModel> LoadUsers()
        {
            string sql = @"select Id, Name, LastName, Email, Description, Age
                           from dbo.UserData;";
            return SqlDataAccess.LoadData<UserModel>(sql);
        }
    }
}
