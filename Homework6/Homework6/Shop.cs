using System;
using System.Collections.Generic;

namespace HwOnlineShop
{
    public class Shop
    {
        private string[] _products =
        {
            "1:Power bank", "2:Flesh card", "3:Usb cable", "4:Charger", "5:Case", "6:Laptop", "7:Keyboard",
            "8:PC mouse", "9:Speakers", "10:Microphone", "11:Monitor", "12:Phone", "4:Screen"
        };

        public void GetProductsList()
        {
            Console.WriteLine(string.Join(" ", _products));
        }

        public string GetProducts(int number)
        {
            string product = _products[number - 1];
            return product;
        }

        public int[] ChoseProducts()
        {
            string? inputNumbers;

            Console.WriteLine("Select products by writing numbers separated by space:");
            inputNumbers = Console.ReadLine();
            string[] number = inputNumbers.Split(" ");
            int[] outputNumbers = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                outputNumbers[i] = int.Parse(number[i]);
            }

            return outputNumbers;
        }

        public void CreateOrder(Cart order, (string name, string lastName) personInfo)
        {
            var random = new Random();
            int orderNumber = random.Next(0, 1000000);
            Console.WriteLine($"Dear {personInfo.name} {personInfo.lastName}, your order number:{orderNumber} has been created." +
                $"The order consist of such goods:{order.GetProducts()}. Thanks for your order!");
            order.EmptyCart();
        }
    }
}