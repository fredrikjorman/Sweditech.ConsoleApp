using Microsoft.Extensions.DependencyInjection;
using Sweditech.ConsoleApp.Customer;

var services = new ServiceCollection();

services.AddSingleton<ICustomerService, CustomerService>();
services.AddTransient<ICustomerDialog, CustomerDialogService>();

var serviceProvider = services.BuildServiceProvider();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("### SWEDITECH ###");
    Console.WriteLine("1. Lägg till kund");
    Console.WriteLine("2. Lägg till produkt");
    Console.WriteLine("3. Lägg till leverantör");
    Console.WriteLine("0. Avsluta");

    Console.Write("Välj ett alternativ: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        var customerDialog =
            serviceProvider.GetRequiredService<ICustomerDialog>();

        customerDialog.RegisterCustomer();
    }
    else if (choice == "0")
    {
        break;
    }
    else
    {
        Console.WriteLine("Det alternativet är inte tillgängligt.");
    }
}