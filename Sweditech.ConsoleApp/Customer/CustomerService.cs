namespace Sweditech.ConsoleApp.Customer;

public class CustomerService : ICustomerService
{
    private readonly List<Customer> _customers = new List<Customer>();

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public List<Customer> GetAllCustomers()
    {
        return _customers;
    }
}