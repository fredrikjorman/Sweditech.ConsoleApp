

namespace Sweditech.ConsoleApp.Services;
using Sweditech.ConsoleApp.Models;


public class ProductDialogService(IProductService productService) : IProductDialog
{
    public void CreateProductDialog()
    {
        Console.WriteLine("Ange produktnamn:");
        string? productName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(productName))
        {
            Console.WriteLine("Produktnamn kan inte vara tomt. Ange produktnamn:");
            Console.WriteLine("Ange produktnamn:");
            productName = Console.ReadLine();
        }


            Console.WriteLine("Ange produktens pris: ");
            string? priceInput = Console.ReadLine();
            int price;


            while (int.TryParse(priceInput, out price) == false || price < 0)
            {
                Console.WriteLine("Du måste ange ett giltigt pris:");
                priceInput = Console.ReadLine();
            }

            Product product = new Product(productName, price);
            productService.AddProduct(product);
            Console.WriteLine("Produkten har sparats!");
            Console.ReadKey();



    }
}

