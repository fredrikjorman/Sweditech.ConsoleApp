using Microsoft.Extensions.DependencyInjection;
using Sweditech.ConsoleApp.Suppliers;

var services = new ServiceCollection();

services.AddSingleton<ISupplierService, SupplierService>();
services.AddTransient<ISupplierDialog, SupplierDialogService>();

var serviceProvider = services.BuildServiceProvider();
var supplierDialog = serviceProvider.GetRequiredService<ISupplierDialog>();

supplierDialog.AddSupplier();