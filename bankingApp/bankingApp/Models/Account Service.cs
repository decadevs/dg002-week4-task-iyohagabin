using bankingApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bankingApp.Enum.TransactionTypeEnum;

namespace bankingApp.Models
{
    public class Account_Service
    {
        public int Id { get; set; }
        public string description {  get; set; }

        public TransactionType TransactionType { get; set; }

        public DateTime date { get; set; }

        public double amount { get; set; }

        public double balance { get; set; }






    }
}
