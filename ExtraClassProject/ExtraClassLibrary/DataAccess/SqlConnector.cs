using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ExtraClassLibrary.Models;

namespace ExtraClassLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public UserModel CreateUser(UserModel model)
        {
          using(System.Data.IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ExtraClass")))
            {
                var user = new DynamicParameters();
                user.Add("@UserName", model.UserName);
                user.Add("@Email", model.Email);
                user.Add("@Password", model.Password);
                user.Add("@Address", model.Address);
                user.Add("@id", 0, System.Data.DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dsdfsd", user, commandType: CommandType.StoredProcedure);
                model.Id = user.Get<int>("@id");
                return model;

            }
            
        }

        public List<RoleModel> GetAllRoles()
        {
            List<RoleModel> roles;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("ExtraClass")))
            {
                roles = connection.Query<RoleModel>("dbo.get_all_roles").ToList();
            }
            return roles;
        }
    }
}
