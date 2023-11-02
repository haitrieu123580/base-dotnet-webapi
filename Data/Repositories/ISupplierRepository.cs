using System.Collections.Generic;
using s002API.Models;

namespace s002API.Data.Repositories
{
    public interface ISupplierRepository
    {
        IEnumerable<SupplierCategory> GetSupplierCategories();
        bool isExistSupplier(int id);
        SupplierCategory GetSupplierById(int id);
        
    }
}