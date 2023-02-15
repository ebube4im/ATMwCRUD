using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDAL
{
    public class DbContext: IDisposable
    {
        private SqlConnection _dbConnection = null;
        private readonly string _connString;
        private bool _disposed;
        public DbContext():this(@"Data Source=4IM-DIGITALS\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
         //   Data Source = 4IM - DIGITALS\SQLEXPRESS; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False

        }

        public DbContext(string connString)
        {
            _connString= connString;
        }

        public async Task<SqlConnection> OpenConnectionAsync()
        {
           
            if (_dbConnection == null)
            {
                _dbConnection = new SqlConnection(_connString);
                await _dbConnection.OpenAsync();
            }

            return _dbConnection;

        }

        public async Task CloseConnectionAsync()
        {
            if (_dbConnection?.State != ConnectionState.Closed)
            {
                await _dbConnection?.CloseAsync();
            }


        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _dbConnection.Dispose();
            }

            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

           
        }
    }
}
