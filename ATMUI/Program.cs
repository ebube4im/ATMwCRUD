using ATMDAL;

namespace ATMUI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
         //   I know you will come here to see what I have done. I am yet to fix a lot of parts.
         //   I will do that when I wake up. I really need to catch some sleep.
         //   For now I just want to make an Initial submission. LOL!

            SeedDbService myservice = new SeedDbService(new DbContext());
   
            string CreateDbResult = await myservice.CreateDB();
            Console.WriteLine(CreateDbResult);

            myservice = new SeedDbService(new DbContext(@"Data Source=4IM-DIGITALS\SQLEXPRESS;Integrated Security=True; Initial Catalog=ATMDb; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
          
          string CreateUserTableResult =  await  myservice.CreateUsersTable();
            
            Console.WriteLine(CreateUserTableResult);
        }
    }
}