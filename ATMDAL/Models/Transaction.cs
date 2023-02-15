using ATMDAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDAL.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public TransactionType TransactionType { get; set; }    

        public string UserId { get; set; }
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
