namespace Sweditech.ConsoleApp.Suppliers;

public interface ISupplierService
{
    void AddSupplier(Supplier supplier);
    List<Supplier> GetSuppliers();
}