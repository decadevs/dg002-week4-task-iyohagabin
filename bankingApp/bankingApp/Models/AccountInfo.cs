using bankingApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bankingApp.Enum.AccountTypeEnum;

namespace bankingApp.Models
{
    internal class AccountInfo
    {
        public int ID { get; set; }

        public string accountNumber { get; set; }

        public double balance { get; set; }

        public AccountType accountType { get; set; }



    }
}
