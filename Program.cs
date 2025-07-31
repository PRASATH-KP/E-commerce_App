using E_commerce_App;

namespace EcommerceApp
{

    internal class Program
    {
        

        public static void Main(string[] args)
        {
            var users = AddDefaultDetails.registrationDetails;
            var products = AddDefaultDetails.productDetails;
            var deposits = AddDefaultDetails.depositDatas;
            var withdraws = AddDefaultDetails.withdrawDatas;

            foreach (var person in users)
            {
                Console.Write($"Role of the Person : {person.UserRole}");
                Console.Write(" ");
                Console.Write($" ID : {person.Id}");
                Console.Write(" ");
                Console.Write($" Name : {person.Name}");
                Console.Write(" ");
                Console.Write($" Balance : {person.WalletBalance}");
                Console.Write(" ");
                Console.Write($" MailId : {person.MailId}");
                Console.WriteLine();
            }

            foreach (var product in products)
            {
                Console.Write($"Product ID : {product.ProductID} ");
                Console.Write(" Product Count : {0} ", product.Quantity);
                Console.Write(" Product Price : " + product.PriceOfProduct);
                Console.WriteLine();
            }

            


            //foreach (var user in registrationDetails)
            //{

            //    //if (person.UserId % 2 == 0)
            //    //{
            //    //   DepositData deposit = new DepositData(person.UserId, 100, DateTime.Now);
            //    //   depositDatas.Add(deposit);
            //    //   person.WalletBalance= deposit.DepositAmmount(100, DateTime.Now, person.WalletBalance);
            //    //}
            //    //else 
            //    //{
            //    //   WithdrawData withdraw = new WithdrawData(person.UserId, 20, DateTime.Now);
            //    //   withdrawDatas.Add(withdraw);
            //    //   person.WalletBalance= withdraw.WithdrawAmmount(20, DateTime.Now, person.WalletBalance);
            //    //}
            //    //Console.Write($"User ID : {person.UserId}");
            //    //Console.Write(" ");
            //    //Console.Write($"User Balance : {person.WalletBalance}");
            //    //Console.WriteLine();
            //}


            Console.ReadLine();

        }
    }
}
