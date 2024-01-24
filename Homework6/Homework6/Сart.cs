using System;
using System.Collections.Generic;

namespace HwOnlineShop
{
    public class Cart
    {
        private Shop shop;
        private int[] products = new int[0];
        private string yourProducts = string.Empty;

        public Cart(Shop shop, int[] product)
        {
            this.shop = shop;

            products = new int[product.Length];
            for (int i = 0; i < product.Length; i++)
            {
                products[i] = product[i];
            }
        }

        public void ShowCart()
        {
            for (int i = 0; i < products.Length; i++)
            {
                yourProducts += " " + shop.GetProducts(products[i]);
            }

            Console.WriteLine("Now in your cart has these items:");

            if (yourProducts == "")
            {
                Console.WriteLine("Your cart empty");
            }
            else
            {
                Console.WriteLine(yourProducts);
            }
        }

        public string GetProducts()
        {
            return yourProducts;
        }

        public void EmptyCart()
        {
            products = new int[0];
            yourProducts = "";
        }
    }
}