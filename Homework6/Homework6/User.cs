using System;

namespace HwOnlineShop
{
    public class User
    {
        private (string, string) info;
        private Shop shop;
        private Cart basket;

        public User((string, string) personInfo, Shop shop)
        {
            info.Item1 = personInfo.Item1;
            info.Item2 = personInfo.Item2;
            this.shop = shop;
        }

        public void LookProducts()
        {
            shop.GetProductsList();
            basket = new Cart(shop, shop.ChoseProducts());
        }

        public void LookCart()
        {
            basket.ShowCart();
        }

        public void MakeOrder()
        {
            shop.CreateOrder(basket, info);
        }
    }
}