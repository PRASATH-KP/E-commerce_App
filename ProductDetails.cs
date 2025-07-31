using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp
{
    public class ProductDetails 
    {
        public int Quantity { get; set; }

        public string ProductName { get; set; }
        public string ProductID {  get; set; }   
        public decimal PriceOfProduct { get; set; }

        private static int p_Id = 100;
        public ProductDetails( string productName, int quantity, decimal priceOfProduct ) 
        {
            p_Id++;
            ProductID = "PId" + p_Id.ToString();
            ProductName = productName;
            Quantity = quantity;
            PriceOfProduct = priceOfProduct;
        }

        //public static int ActionOnProduct( int productID , int noOfItems , )
    }
}
