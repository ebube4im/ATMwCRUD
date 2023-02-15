using ATMBLL.Interfaces;
using ATMDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBLL.Services
{
    internal class UserService : IUserService
    {
        public async Task<bool> CreateUser(User user)
        {
            await User.CreateUser(new ATMDAL.DbContext(), user);
            return false;
        }

        public Task<bool> DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
