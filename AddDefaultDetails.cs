namespace EcommerceApp
{
    public class AddDefaultDetails
    {
        public static List<RegistrationDetails> registrationDetails = new List<RegistrationDetails>();
        public static List<ProductDetails> productDetails = new List<ProductDetails>();
        public static List<DepositData> depositDatas = new List<DepositData>();
        public static List<WithdrawData> withdrawDatas = new List<WithdrawData>();

        static AddDefaultDetails()
        {
            // RegistrationDetails
            registrationDetails.Add(new RegistrationDetails(Role.Manager, "Palani", "palani@gmail.com"));       // ManagerId101
            registrationDetails.Add(new RegistrationDetails(Role.Admin, "Paul Johnson", "paul.johnson@gmail.com")); // AdminId101
            registrationDetails.Add(new RegistrationDetails("Olivia Smith", "olivia.smith@gmail.com", 1500));    // UserId101
            registrationDetails.Add(new RegistrationDetails("Liam Davis", "liam.davis@gmail.com", 1200));        // UserId102
            registrationDetails.Add(new RegistrationDetails("Sophia Brown", "sophia.brown@gmail.com", 1000));    // UserId103
            registrationDetails.Add(new RegistrationDetails(Role.Admin, "Alex Wilson", "alex.wilson@gmail.com")); // AdminId102
            registrationDetails.Add(new RegistrationDetails("Daniel Miller", "daniel.miller@gmail.com", 800));   // UserId104
            registrationDetails.Add(new RegistrationDetails("Fiona Moore", "fiona.moore@gmail.com", 2500));      // UserId105

            // ProductDetails
            productDetails.Add(new ProductDetails("Apple iPhone 14", 10, 799));
            productDetails.Add(new ProductDetails("Samsung Galaxy S22", 20, 699));
            productDetails.Add(new ProductDetails("Google Pixel 7", 15, 599));
            productDetails.Add(new ProductDetails("Sony WH-1000XM5 Headphones", 30, 349));
            productDetails.Add(new ProductDetails("Dell XPS 13 Laptop", 5, 999));
            productDetails.Add(new ProductDetails("Logitech MX Master 3 Mouse", 25, 99));
            productDetails.Add(new ProductDetails("Apple iPad Air", 12, 599));

            // DepositData 
            depositDatas.Add(new DepositData("UserId101", 500, DateTime.Now.AddDays(-3))); // Olivia
            depositDatas.Add(new DepositData("UserId102", 300, DateTime.Now.AddDays(-2))); // Liam
            depositDatas.Add(new DepositData("UserId103", 700, DateTime.Now.AddDays(-1))); // Sophia

            // WithdrawData
            withdrawDatas.Add(new WithdrawData("UserId101", 100, DateTime.Now));             // Olivia
            withdrawDatas.Add(new WithdrawData("UserId103", 200, DateTime.Now.AddDays(-1))); // Sophia
            withdrawDatas.Add(new WithdrawData("UserId104", 100, DateTime.Now));             // Daniel
            withdrawDatas.Add(new WithdrawData("UserId105", 50, DateTime.Now));              // Fiona
        }
    }
}


