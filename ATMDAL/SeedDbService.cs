using Microsoft.Data.SqlClient;

namespace ATMDAL
{
    public class SeedDbService
    {
        private readonly DbContext _dbContext;
        private bool _disposed;
        SqlConnection sqlConn;
        public SeedDbService(DbContext dbContext)
        {

            _dbContext = dbContext;

        }

        public async Task<string> CreateDB()
        {
           sqlConn = await _dbContext.OpenConnectionAsync();

            string createDbQuery =
              $"IF NOT EXISTS ( SELECT * FROM sys.databases where name = 'ATMDb')"
                + "BEGIN CREATE DATABASE ATMDb END";

            /*
             * 
             
            CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](20) NULL,
	[LastName] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[RoleId] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
             
                CREATE TABLE Users(
	            UserID int IDENTITY(1,1) NOT NULL,
	            [Name] [varchar](255) NOT NULL,
	            [Email] [varchar](255) NOT NULL,
	            [PhoneNumber] [varchar](255) NOT NULL,
	            [ProfileImage] [varchar](255) NULL)
 
             IF NOT EXISTS ( SELECT * FROM sys.tables where name = 'Users' and type = 'U')
BEGIN
 CREATE TABLE Users(
	UserID int IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[PhoneNumber] [varchar](255) NOT NULL,
	[ProfileImage] [varchar](255) NULL)
 END
GO
             
             */

            await using SqlCommand command = new SqlCommand(createDbQuery, sqlConn);

            var result = await command.ExecuteScalarAsync();

         
            return "Created";
        }

        public async Task<string> CreateUsersTable()
        {
            sqlConn = await _dbContext.OpenConnectionAsync();
            
            string createUsersQuery = @"   
                                     CREATE TABLE [dbo].[Users](
	                                  [UserID] [int] IDENTITY(1,1) NOT NULL,
	                                  [FirstName] [varchar](20) NULL,
	                                  [LastName] [varchar](20) NOT NULL,
	                                  [Email] [varchar](50) NOT NULL,
	                                  [PhoneNumber] [varchar](50) NOT NULL,
                                      [RoleId] [int] NULL,
                                      CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED" +
                                     "([UserID] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF," +
                                    " IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON," + 
                                    " OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY]";

            await using SqlCommand command = new SqlCommand(createUsersQuery, sqlConn);

            var result = await command.ExecuteScalarAsync();

            return "Created Users Table";
        }

        public async Task<string> CreateTransactionTable()
        {
            sqlConn = await _dbContext.OpenConnectionAsync();

            string createTransactionsQuery = @"   
                                     CREATE TABLE [dbo].[Transactions](
	                                  [UserID] [int] IDENTITY(1,1) NOT NULL,
	                                  [FirstName] [varchar](20) NULL,
	                                  [LastName] [varchar](20) NOT NULL,
	                                  [Email] [varchar](50) NOT NULL,
	                                  [PhoneNumber] [varchar](50) NOT NULL,
                                      [RoleId] [int] NULL,
                                      CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED" +
                                     "([UserID] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF," +
                                    " IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON," +
                                    " OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY]";

            await using SqlCommand command = new SqlCommand(createTransactionsQuery, sqlConn);

            var result = await command.ExecuteScalarAsync();

            return "Created Transactions Table";
        }

        public async Task<string> CreateAccountTable()
        {
            sqlConn = await _dbContext.OpenConnectionAsync();

            string createAccountQuery = @"   
                                     CREATE TABLE [dbo].[Account](
	                                  [UserID] [int] IDENTITY(1,1) NOT NULL,
	                                  [FirstName] [varchar](20) NULL,
	                                  [LastName] [varchar](20) NOT NULL,
	                                  [Email] [varchar](50) NOT NULL,
	                                  [PhoneNumber] [varchar](50) NOT NULL,
                                      [RoleId] [int] NULL,
                                      CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED" +
                                     "([UserID] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF," +
                                    " IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON," +
                                    " OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY]";

            await using SqlCommand command = new SqlCommand(createAccountQuery, sqlConn);

            var result = await command.ExecuteScalarAsync();

            return "Created Account table";
        }

        public async Task<string> CreateCardTable()
        {
            sqlConn = await _dbContext.OpenConnectionAsync();

            string createCardQuery = @"   
                                     CREATE TABLE [dbo].[Card](
	                                  [UserID] [int] IDENTITY(1,1) NOT NULL,
	                                  [FirstName] [varchar](20) NULL,
	                                  [LastName] [varchar](20) NOT NULL,
	                                  [Email] [varchar](50) NOT NULL,
	                                  [PhoneNumber] [varchar](50) NOT NULL,
                                      [RoleId] [int] NULL,
                                      CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED" +
                                     "([UserID] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF," +
                                    " IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON," +
                                    " OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]) ON [PRIMARY]";

            await using SqlCommand command = new SqlCommand(createCardQuery, sqlConn);

            var result = await command.ExecuteScalarAsync();

            return "Created Card Table";
        }


        protected virtual void Dispose(bool disposing)
        {

            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _dbContext.Dispose();
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
