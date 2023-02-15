using ATMDAL.Enums;
using ATMDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATMBLL.Interfaces
{
    internal interface ITransactionService
    {
        Task<bool> CreateTransaction(Transaction transaction);
        Task<bool> DeleteTransaction(Transaction transaction);

        Task<bool> UpdateTransaction(Transaction transaction);
        Task<IEnumerable<Transaction>> GetAllTransactions();

        Task<IEnumerable<Transaction>> GetAllTransactionsbyAccountId(int Id);

        Task<IEnumerable<Transaction>> GetAllTransactionsbyTransactionType(TransactionType Ttype);

        Task<IEnumerable<Transaction>> GetAllTransactionsbyTransactionDate(DateTime dt);

        //Task<IEnumerable<Transaction>> GetAllTransactions();
    }
}
