namespace Sweditech.ConsoleApp.Suppliers;

public class SupplierDialogService : ISupplierDialog
{
    private readonly ISupplierService _supplierService;

    public SupplierDialogService(ISupplierService supplierService)
    {
        _supplierService = supplierService;
    }

    public void AddSupplier()
    {
        Console.WriteLine("Ange företagsnamn:");
        string companyName = Console.ReadLine()?? "";

        Console.WriteLine("Ange telefonnumert:");
        string phoneNumber = Console.ReadLine() ?? "";

        Supplier supplier = new Supplier(companyName, phoneNumber);

        _supplierService.AddSupplier(supplier);

        Console.WriteLine("Leverantören har sparats!");
        Console.WriteLine($"Företagsnamn: {supplier.CompanyName}");
        Console.WriteLine($"Telefonnummer: {supplier.PhoneNumber}");
    }

    
}