

using s002API.Models;

namespace s002API.Data.Repositories
{
    public interface ISupplierCategoryRepo
    {
        SupplierCategory GetSupplierCategoryById(int id);
        bool DeleteSupplierCategoryById(int id);
        SupplierCategory Create(Supplier supplier, int categoryId);
    }
}