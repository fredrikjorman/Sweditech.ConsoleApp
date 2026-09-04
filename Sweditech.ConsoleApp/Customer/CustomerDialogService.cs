namespace Sweditech.ConsoleApp.Customer;

public class CustomerDialogService : ICustomerDialog
{
    private readonly ICustomerService _customerService;

    public CustomerDialogService(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    public void RegisterCustomer()
    {
        Console.Write("Ange kundens namn: ");
        string name = Console.ReadLine();

        Console.Write("Ange kundens e-postadress: ");
        string email = Console.ReadLine();

        Customer customer = new Customer
        {
            Namn = name,
            Email = email
        };

        _customerService.AddCustomer(customer);

        Console.WriteLine($"Kunden {customer.Namn} har lagts till.");
    }
}