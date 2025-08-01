namespace EcommerceApp
{

    internal class Program
    {


        public static RegistrationDetails _currentUser;
        public static void Main(string[] args)
        {



  
            bool loginCheck=true;
            int option;

            Console.WriteLine("Welcome to E-Commerce App");
            Console.WriteLine("Choose the oprtions below to proceed furhter \n 1.Login as existing User \n 2.Register as New User \n 3.Others ");
            do 
            {

                loginCheck = int.TryParse(Console.ReadLine(), out option);
                if ((loginCheck && (option >= 1 && option <= 3)))
                    break;
                Console.WriteLine("You have given worng option");
            }
            while (!(loginCheck &&(option>=1 && option<=3)));

            switch (option)
            {
                case 1:
                    _currentUser = login();
                    MainMenu();
                    break;
                case 2:
                    _currentUser = Regsiter();
                    MainMenu();
                    break;
                //case 3:
                    
            };

            

            //foreach (var person in users)
            //{
            //    Console.Write($"Role of the Person : {person.UserRole}");
            //    Console.Write(" ");
            //    Console.Write($" ID : {person.Id}");
            //    Console.Write(" ");
            //    Console.Write($" Name : {person.Name}");
            //    Console.Write(" ");
            //    Console.Write($" Balance : {person.WalletBalance}");
            //    Console.Write(" ");
            //    Console.Write($" MailId : {person.MailId}");
            //    Console.WriteLine();
            //}

            //foreach (var product in products)
            //{
            //    Console.Write($"Product ID : {product.ProductID} ");
            //    Console.Write(" Product Count : {0} ", product.Quantity);
            //    Console.Write(" Product Price : " + product.PriceOfProduct);
            //    Console.WriteLine();
            //}


            //foreach (var user in UserDetails)
            //{

            //    //if (user.UserId % 2 == 0)
            //    //{
            //    //   DepositData deposit = new DepositData(user.UserId, 100, DateTime.Now);
            //    //   depositDatas.Add(deposit);
            //    //   user.WalletBalance= deposit.DepositAmmount(100, DateTime.Now, user.WalletBalance);
            //    //}
            //    //else 
            //    //{
            //    //   WithdrawData withdraw = new WithdrawData(user.UserId, 20, DateTime.Now);
            //    //   withdrawDatas.Add(withdraw);
            //    //   user.WalletBalance= withdraw.WithdrawAmmount(20, DateTime.Now, user.WalletBalance);
            //    //}
            //    //Console.Write($"User ID : {user.UserId}");
            //    //Console.Write(" ");
            //    //Console.Write($"User Balance : {user.WalletBalance}");
            //    //Console.WriteLine();
            //}


            //Console.ReadLine();

        }

        private static void MainMenu()
        {
            throw new NotImplementedException();
        }

        public static RegistrationDetails login()
        {
            return null;
        }
        public static RegistrationDetails Regsiter()
        {
            return null;
        }
    }
}
