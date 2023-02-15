using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDAL.Models
{
    internal class Card
    {
        public int Id { get; set; }

        public int  CardNumber { get; set; }
        public string CardName { get; set; }
        public string CardPin { get; set; }
        public string CVV { get; set; }

        private string _ExpiryDate; 

        public DateOnly ExpiryMonth { get; set; }

        public DateOnly ExpiryYear { get; set; }

        public string ExpiryDate { get => _ExpiryDate; set => _ExpiryDate = ExpiryMonth.ToString() + "/" + ExpiryYear.ToString(); }
    }
}
