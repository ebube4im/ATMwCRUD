using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMDAL.Models;

namespace ATMBLL.Interfaces
{
    internal interface IAccountService
    {
        Task<bool> CreateAccount(Account account);
        Task<bool> DeleteAccount(Account account);
        Task<bool> UpdateAccountBalance(Account account);
        
    }
}
