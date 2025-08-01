using System.Reflection.Metadata;

namespace EcommerceApp
{

    internal class Program
    {
        public static List<WithdrawData> _widthdrawDetails = AddDefaultDetails.withdrawDatas;
        public static List<DepositData> _depositDetails = AddDefaultDetails.depositDatas;
        public static  List <RegistrationDetails> _userDetails = AddDefaultDetails.registrationDetails;
        public static RegistrationDetails? _currentUser;
        public static List<ProductDetails> _productDetails = AddDefaultDetails.productDetails;
        public static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {

            bool loginCheck = true;
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
            while (!(loginCheck && (option >= 1 && option <= 3)));

            switch (option)
            {
                case 1:
                    _currentUser = login();
                    SubMenu();
                    break;
                case 2:
                    _currentUser = Regsiter();
                    MainMenu();
                    break;
            };
        }

        private static void SubMenu()
        {
            bool menuCheck = true;
            int option;
            Console.WriteLine($"Hi {_currentUser.Name}, Welcome");
            Console.WriteLine("Choose the oprtions below to proceed furhter \n 1.Update my details  \n 2. List of Available Product \n 3.My Deposit Summary \n 4. My Widthdraw Summary \n ");
            do
            {

                menuCheck = int.TryParse(Console.ReadLine(), out option);
                if ((menuCheck && (option >= 1 && option <= 4)))
                    break;
                Console.WriteLine("You have given worng option");
            }
            while (!(menuCheck && (option >= 1 && option <= 4)));

            switch (option)
            {
                case 1:
                    UpdateDetails();
                    break;
                case 2:
                    ListOfProducts();
                    break;
                case 3:
                    DepositSummary();
                    break;
                case 4:
                    WidthdrawSummary();
                    break ;
            };
        }

        private static void WidthdrawSummary()
        {
            Console.WriteLine($"The Widthdraw details of {_currentUser.Name}");

            foreach (var widthraw in _widthdrawDetails)
            {
                if(widthraw.UserId == _currentUser.Id)
                {
                    Console.Write($"widthraw Ammount = {widthraw.Ammount} ");
                    Console.Write($" Time of Withdraw  {widthraw.TimeWithdraw} ");
                    Console.WriteLine();
                }
            }
            SubMenu();

        }

        private static void DepositSummary()
        {
            Console.WriteLine($"The Deposit details of {_currentUser.Name}");

            foreach (var DepositData in _depositDetails)
            {
                if (DepositData.UserId == _currentUser.Id)
                {
                    Console.Write($"widthraw Ammount = {DepositData.Ammount} ");
                    Console.Write($" Time of Withdraw  {DepositData.TimeofDeposit} ");
                    Console.WriteLine();
                }
            }
            SubMenu();
        }
            while (!(loginCheck && (option >= 1 && option <= 3)));

        private static void ListOfProducts()
        {
            foreach (var product in _productDetails)
            {
                Console.Write($"Product ID : {product.ProductID} ");
                Console.Write($"Product Name : {product.ProductName} ");
                Console.Write(" Product Count : {0} ", product.Quantity);
                Console.Write(" Product Price : " + product.PriceOfProduct);
                Console.WriteLine();
            }
            SubMenu();

        }

        private static void UpdateDetails()
        {
            SubMenu();
        }

        public static RegistrationDetails login()
        {
            
            bool Found = false;
            
            do
            {
                Console.WriteLine("Enter User Id to Login or press 0 to Exit");
                string Id = Console.ReadLine().ToString();

                if (Id == "0")//Add null handling
                {
                    Found = false;
                    MainMenu();
                }
                foreach (var user in _userDetails)
                {

                    if (user.Id.ToLower() == Id.ToLower() && user.UserRole == Role.User)
                        
                    {
                        Console.WriteLine("Success");
                        Found = true;
                        return user;

                    }
                }
                if (!Found)
                {
                    Console.WriteLine($"Not Found for this ID {Id} try again or press 0 to Exit");
                }
            } while (!Found);
            
            return null;
        }
        public static RegistrationDetails Regsiter()
        {
            return null;
        }
    }
}
