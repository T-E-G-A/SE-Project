using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WindowsFormsApp2
{
    public class registerRepo : IregisterRepo
    {
        public async Task<bool> Insert(register user)
        {
            using(IDbConnection db=new SqlConnection(AppHelper.ConnectionString))
            {
                var result = await db.ExecuteAsync(WindowsFormsApp2.Properties.Resources.InsertUser, new { Username = user.Username, Email = user.Email, Password = user.Password });
                    return result > 0;
            }
        }
    }
}
