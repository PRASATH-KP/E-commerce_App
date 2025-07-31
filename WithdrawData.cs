using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    public class WithdrawData 
    {
        public int UserId { get; set; } 
        public decimal Ammount { get; set; }
        public DateTime TimeWithdraw {  get; set; } 

        public WithdrawData(int userId, decimal ammount, DateTime timeWithdraw)
        {
            UserId = userId;
            Ammount = ammount;
            TimeWithdraw = timeWithdraw;
        }

        public decimal WithdrawAmmount( decimal ammount, DateTime TimeofAction , decimal balance)
        {
            return balance = balance - ammount;
        }
    
    }
}
