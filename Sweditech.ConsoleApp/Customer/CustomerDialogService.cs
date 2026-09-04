namespace Sweditech.ConsoleApp.Customer;

public class CustomerDialogService : ICustomerDialog
{
    private readonly ICustomerService _customerService;
    public CustomerDialogService(ICustomerService customerService)
    {
        _customerService = customerService;
    }

   public void ShowCustomerDialog()
    {
        Console.WriteLine("Ange kundens namn: ");
        var name = Console.ReadLine();
        Console.WriteLine("Ange kundens email: ");
        var email = Console.ReadLine();
        var customer = new Customer { Namn = name, Email = email };
        _customerService.AddCustomer(customer);
        Console.WriteLine($"Kund {name} har lagts till");
    }
}
