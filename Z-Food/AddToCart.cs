using System;
namespace Z_Food
{
    public class AddToCart
    {
        public static AddToCart AddToCartObj = new AddToCart();
        private AddToCart()
        {
        }
        public static AddToCart GetInstance()
        {
            return AddToCartObj;
        }
        public void AddItems()
        {

        }
    }
}

