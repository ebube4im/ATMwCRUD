using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMBLL;
using ATMDAL.Models;

namespace ATMBLL.Interfaces
{
    internal interface IUserService
    {
        Task<bool> CreateUser(User user);

        Task<bool> UpdateUser(User user);

        Task<bool> DeleteUser(User user);

        Task<User> GetUserById(int id);
        Task<IEnumerable<User>> GetAllUsers();

    }
}
