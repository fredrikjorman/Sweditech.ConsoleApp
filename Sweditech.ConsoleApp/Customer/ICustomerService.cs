namespace Sweditech.ConsoleApp.Customer;

public interface ICustomerService
{
    void AddCustomer(Customer customer);
    List<Customer> GetAllCustomers();
}
