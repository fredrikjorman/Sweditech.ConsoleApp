using Sweditech.ConsoleApp.Services;

IProductService productService = new ProductService();

IProductDialog productDialog = new ProductDialogService(productService);

productDialog.CreateProductDialog();
