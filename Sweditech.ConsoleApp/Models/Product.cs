namespace Sweditech.ConsoleApp.Models;

public class Product(string productName, int price)
{
        public string ProductName { get; set; } = productName;
        public int Price { get; set; } = price;
  
}
