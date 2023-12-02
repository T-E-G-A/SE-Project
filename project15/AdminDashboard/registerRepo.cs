using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AdminDashboard
{
    public class registerRepo : IregisterRepo
    {
        public async Task<bool> Insert(Reg user)
        {
            using(IDbConnection db=new SqlConnection(AppHelper.ConnectionString))
            {
                var result=await db.ExecuteAsync(AdminDashboard.Properties.Resources.InsertUser,new {Username = user.Username, Password = user.Password, Email = user.Email});
                return result > 0;
            }
        }
    }
}
