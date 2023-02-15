using ATMDAL.Enums;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDAL.Models
{
    public class User
    {
        private static readonly DbContext _dbContext;

        protected User(long id, string password)
        {
            Password = password;
            Id = id;
        }
        private bool _disposed;
       static SqlConnection sqlConn;
       

        public long Id { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; }
        public string PhoneNumber { get; set; }
        public virtual Role Role { get; }


       public static async Task<string> CreateUser(DbContext db, User user)
        {
            sqlConn = await _dbContext.OpenConnectionAsync();

            string InsertDbQuery =
              $"INSERT INTO Users VALUES ()";


            await using SqlCommand command = new SqlCommand(InsertDbQuery, sqlConn);

            var result = await command.ExecuteScalarAsync();


            return "Inserted Seed Users";
        }
 
        
     

       

    }
}

 