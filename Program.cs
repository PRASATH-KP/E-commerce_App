namespace EcommerceApp
{

    internal class Program
    {
        public static List<DepositData> depositDatas = new List<DepositData>();
        public static List<WithdrawData> withdrawDatas = new List<WithdrawData>();
        public static List<UserDetails> UserDetails = new List<UserDetails>();
        public static List<ProductDetails> productDetails = new List<ProductDetails>();

        public static void Main(string[] args)
        {

            UserDetails.Add(new UserDetails(1000, "p@gmail.com"));
            UserDetails.Add(new UserDetails(2000, "o@gmail.com"));
            UserDetails.Add(new UserDetails(3000, "l@gmail.com"));
            UserDetails.Add(new UserDetails(400, "s@gmail.com"));
            UserDetails.Add(new UserDetails(100, "a@gmail.com"));
            UserDetails.Add(new UserDetails(900, "d@gmail.com"));
            UserDetails.Add(new UserDetails(800, "f@gmail.com"));

            productDetails.Add(new ProductDetails(10, 600));
            productDetails.Add(new ProductDetails(20, 500));
            productDetails.Add(new ProductDetails(90, 400));
            productDetails.Add(new ProductDetails(50, 200));

            foreach (var product in productDetails)
            {
                Console.Write($"Product ID : {product.ProductID} ");
                Console.Write(" Product Count : {0} ", product.Count);
                Console.Write(" Product Price : " + product.PriceOfProduct);
                Console.WriteLine();



            }

            foreach (var user in UserDetails)
            {
                Console.Write($"User ID : {user.UserId}");
                Console.Write(" ");
                Console.Write($"User Balance : {user.WalletBalance}");
                Console.Write(" ");
                Console.Write($"User MailId : {user.MailId}");
                Console.WriteLine();
            }


            foreach (var user in UserDetails)
            {

                //if (user.UserId % 2 == 0)
                //{
                //   DepositData deposit = new DepositData(user.UserId, 100, DateTime.Now);
                //   depositDatas.Add(deposit);
                //   user.WalletBalance= deposit.DepositAmmount(100, DateTime.Now, user.WalletBalance);
                //}
                //else 
                //{
                //   WithdrawData withdraw = new WithdrawData(user.UserId, 20, DateTime.Now);
                //   withdrawDatas.Add(withdraw);
                //   user.WalletBalance= withdraw.WithdrawAmmount(20, DateTime.Now, user.WalletBalance);
                //}
                //Console.Write($"User ID : {user.UserId}");
                //Console.Write(" ");
                //Console.Write($"User Balance : {user.WalletBalance}");
                //Console.WriteLine();
            }


            Console.ReadLine();

        }
    }
}
