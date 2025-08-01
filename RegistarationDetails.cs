using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    public enum Role
    {
        Manager,
        Admin,
        User
    }
    public class RegistrationDetails
    {  
        private string _iD;
        public string Id 
        { 
            get 
            { 
                return _iD; 
            } 
        }
        private static int user_Id = 100;

        private static int admin_Id = 100;

        private static int manager_Id = 100;
        public Role UserRole { get; set; }
        public string Name { get; set; }
        public string MailId { get; set; }
        public decimal? WalletBalance { get; set; }        
        public RegistrationDetails(Role userRole, string name, string mailID)
        {
            if (userRole == Role.User)
                throw new ArgumentException("Use the user constructor for non-admin roles");

            UserRole = userRole;
            if(userRole == Role.Admin)
            {
                admin_Id++;
                _iD = "AdminId" + admin_Id;
            Name = name;
                MailId = mailID;
            }
            if (userRole == Role.Manager)
            {
                manager_Id++;
                _iD = "ManagerId" + manager_Id;
                Name = name;
                MailId = mailID;
            }
            WalletBalance = null;
        }

        // User Constructor
        public RegistrationDetails(string name, string mailID, decimal walletBalance)
        {
            UserRole = Role.User;
            user_Id++;
            _iD = "UserId" + user_Id;
            Name = name;
            WalletBalance = walletBalance;
            MailId = mailID;
        }

    }
}
