using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using RunHuaAdmin.Models;

namespace RunHuaAdmin.Repository
{
    public class OrderRepository
    {
        private readonly string connStr = @"Data Source=ruhua.database.windows.net;Initial Catalog=ruhua;Persist Security Info=True;User ID=ruhua;Password=!2Qwaszx";

        public List<OrderViewModel> GetAllOrder()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"select CompanyName,StudentName,Color,Count,Status from [dbo].[Order]";
                var tempList = conn.Query<dynamic>(sql).ToList();
               
                var result = (from t in tempList
                    select new OrderViewModel
                    {
                        CompanyName = t.CompanyName,
                        StudentName = t.StudentName.Split(','),
                        Color = t.Color.Split(','),
                        Amount = t.Count,
                        Status = t.Status
                    }).ToList();

                
                return result;
            }
        }
    }
}