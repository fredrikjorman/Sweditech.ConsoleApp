namespace Sweditech.ConsoleApp.Suppliers;

public class SupplierService : ISupplierService
{
    private List<Supplier> _suppliers = new List<Supplier>();

    public void AddSupplier(Supplier supplier)
    {
        _suppliers.Add(supplier);
    }

    public List<Supplier> GetSuppliers()
    {
        return _suppliers;
    }
}