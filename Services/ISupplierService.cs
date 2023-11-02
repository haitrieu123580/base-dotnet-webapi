
using System.Collections.Generic;
using s002API.Dtos;
using s002API.Models;

namespace s002API.Services
{
    public interface ISupplierService
    {
        IEnumerable<SupplierResDto> GetSupplierCategories();
        SupplierResDto GetSupplierWithCategoryById(int scId);
        bool DeleteSupplierCategoryById(int scId);
        SupplierResDto Create();
    }
}

