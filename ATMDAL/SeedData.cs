using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDAL
{
    internal class SeedData
    {
        private readonly DbContext _dbContext;
        private bool _disposed;
        SqlConnection sqlConn;
        public SeedData(DbContext dbContext)
        {

            _dbContext = dbContext;

        }

        public async Task<string> InsertSeedUsers()
        {
            sqlConn = await _dbContext.OpenConnectionAsync();

            string InsertDbQuery =
              $"INSERT INTO Users VALUES ()";

           
            await using SqlCommand command = new SqlCommand(InsertDbQuery, sqlConn);

            var result = await command.ExecuteScalarAsync();


            return "Inserted Seed Users";
        }

        public async Task<string> InsertSeedRoles()
        {
            sqlConn = await _dbContext.OpenConnectionAsync();

            string InsertDbQuery =
              $"INSERT INTO Users VALUES ()";


            await using SqlCommand command = new SqlCommand(InsertDbQuery, sqlConn);

            var result = await command.ExecuteScalarAsync();


            return "Inserted Seed Users";
        }

        public async Task<string> InsertSeedTransactionTypes()
        {
            sqlConn = await _dbContext.OpenConnectionAsync();

            string InsertDbQuery =
              $"INSERT INTO Users VALUES ()";


            await using SqlCommand command = new SqlCommand(InsertDbQuery, sqlConn);

            var result = await command.ExecuteScalarAsync();


            return "Inserted Seed Users";
        }

        public async Task<string> InsertAccountType()
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
