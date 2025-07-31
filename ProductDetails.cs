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
        public int Count { get; set; } 
        public string ProductID {  get; set; }   
        public decimal PriceOfProduct { get; set; }

        private static int p_Id = 100;
        public ProductDetails( int count, decimal priceOfProduct ) 
        {
            p_Id++;
            ProductID = "PID" + p_Id.ToString();
            Count = count;
            PriceOfProduct = priceOfProduct;
        }

        //public static int ActionOnProduct( int productID , int noOfItems , )
    }
}
