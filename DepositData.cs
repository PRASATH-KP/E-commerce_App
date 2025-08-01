using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    public class DepositData
    {
        public string UserId { get; set; }
        public decimal Ammount { get; set; }
        public DateTime TimeofDeposit { get; set; }
        public  DepositData(string userId, decimal ammount, DateTime timeofDeposit)
        {
            UserId = userId;
            Ammount = ammount;
            TimeofDeposit = timeofDeposit;
        }
        public decimal DepositAmmount(decimal ammount, DateTime TimeofAction, decimal balance)
        {
            return balance = balance + ammount;
        }

    }
}
