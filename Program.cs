namespace EcommerceApp
{

    internal class Program
    {
        public static List<DepositData> depositDatas = new List<DepositData>();
        public static List<WithdrawData> withdrawDatas = new List<WithdrawData>();
        public static List<RegistrationDetails> registrationDetails = new List<RegistrationDetails>();
        public static List<ProductDetails> productDetails = new List<ProductDetails>();

        public static void Main(string[] args)
        {

            registrationDetails.Add(new RegistrationDetails(Role.Manager, "Palani", "palani@gmail.com"));
            registrationDetails.Add(new RegistrationDetails(Role.Admin, "Paul Johnson", "paul.johnson@gmail.com"));
            registrationDetails.Add(new RegistrationDetails("Olivia Smith", "olivia.smith@gmail.com", 1500));
            registrationDetails.Add(new RegistrationDetails("Liam Davis", "liam.davis@gmail.com", 1200));
            registrationDetails.Add(new RegistrationDetails("Sophia Brown", "sophia.brown@gmail.com", 1000));
            registrationDetails.Add(new RegistrationDetails(Role.Admin, "Alex Wilson", "alex.wilson@gmail.com"));
            registrationDetails.Add(new RegistrationDetails("Daniel Miller", "daniel.miller@gmail.com", 800));
            registrationDetails.Add(new RegistrationDetails("Fiona Moore", "fiona.moore@gmail.com", 2500));


            productDetails.Add(new ProductDetails("Apple iPhone 14", 10, 799));
            productDetails.Add(new ProductDetails("Samsung Galaxy S22", 20, 699));
            productDetails.Add(new ProductDetails("Google Pixel 7", 15, 599));
            productDetails.Add(new ProductDetails("Sony WH-1000XM5 Headphones", 30, 349));
            productDetails.Add(new ProductDetails("Dell XPS 13 Laptop", 5, 999));
            productDetails.Add(new ProductDetails("Logitech MX Master 3 Mouse", 25, 99));
            productDetails.Add(new ProductDetails("Apple iPad Air", 12, 599));

            foreach (var person in registrationDetails)
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

            foreach (var product in productDetails)
            {
                Console.Write($"Product ID : {product.ProductID} ");
                Console.Write(" Product Count : {0} ", product.Quantity);
                Console.Write(" Product Price : " + product.PriceOfProduct);
                Console.WriteLine();
            }

            


            foreach (var user in registrationDetails)
            {

                //if (person.UserId % 2 == 0)
                //{
                //   DepositData deposit = new DepositData(person.UserId, 100, DateTime.Now);
                //   depositDatas.Add(deposit);
                //   person.WalletBalance= deposit.DepositAmmount(100, DateTime.Now, person.WalletBalance);
                //}
                //else 
                //{
                //   WithdrawData withdraw = new WithdrawData(person.UserId, 20, DateTime.Now);
                //   withdrawDatas.Add(withdraw);
                //   person.WalletBalance= withdraw.WithdrawAmmount(20, DateTime.Now, person.WalletBalance);
                //}
                //Console.Write($"User ID : {person.UserId}");
                //Console.Write(" ");
                //Console.Write($"User Balance : {person.WalletBalance}");
                //Console.WriteLine();
            }


            Console.ReadLine();

        }
    }
}
