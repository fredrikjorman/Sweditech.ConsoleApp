namespace Sweditech.ConsoleApp.Suppliers;

public class Supplier
{
    public string CompanyName { get; set; }
    public string PhoneNumber { get; set; }

    public Supplier(string companyName, string phoneNumber)
    {
        CompanyName = companyName;
        PhoneNumber = phoneNumber;
    }
}