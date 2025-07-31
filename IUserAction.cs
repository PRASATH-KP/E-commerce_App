using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    public  interface IUserAction
    {
        
         void ActionOnAmmount(decimal ammount, DateTime TimeofAction, decimal balance);
       
    }
}
