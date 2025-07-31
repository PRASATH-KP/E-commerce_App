using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    public class UserDetails
    {
        private string _userId;
        public string UserId 
        { 
            get 
            { 
                return _userId; 
            } 
        }

        private static int s_id = 100;

        public string MailId { get; set; }

        public decimal WalletBalance { get; set; }

        public UserDetails( decimal walletBalance, string mailID)
        {
            s_id++;
            _userId = "CID" + s_id;
            WalletBalance = walletBalance;
            MailId = mailID;
        }
    }
}
