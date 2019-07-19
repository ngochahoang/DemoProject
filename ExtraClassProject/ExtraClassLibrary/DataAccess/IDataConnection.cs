using ExtraClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtraClassLibrary.DataAccess
{
    public interface IDataConnection
    {
        UserModel CreateUser (UserModel model);
        // ClassModel CreateClass(ClassModel model);
        List<RoleModel> GetAllRoles();

        
    }
}
