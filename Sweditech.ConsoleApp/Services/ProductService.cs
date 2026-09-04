
using Sweditech.ConsoleApp.Models;
namespace Sweditech.ConsoleApp.Services;

internal class ProductService : IProductService

{

    private readonly List<Product> _products = [];

    public void AddProduct(Product product)
    {

        _products.Add(product);

    }
}

