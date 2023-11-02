using System.Linq;
using s002API.Models;
using Microsoft.EntityFrameworkCore; // Thêm using này
using s002API.Data;
using System;
namespace s002API.Data.Repositories
{
    public class SupplierCategoryRepo : ISupplierCategoryRepo
    {
        private readonly AppDbContext _context;
        public SupplierCategoryRepo(AppDbContext context)
        {
            _context = context;
        }
        public SupplierCategory GetSupplierCategoryById(int id)
        {
            var result = _context.SupplierCategories
                    .Include(sc => sc.Supplier)
                    .Include(sc => sc.Category)
                    .Where(sc => sc.Id == id)
                    .FirstOrDefault();
            return result;
        }
        public bool DeleteSupplierCategoryById(int id)
        {
            try
            {
                var entityToDelete = _context.SupplierCategories.FirstOrDefault(sc => sc.Id == id);
                if (entityToDelete != null)
                {
                    _context.SupplierCategories.Remove(entityToDelete);
                    int result = _context.SaveChanges();
                    return (result > 0) ? true : false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                Console.WriteLine($"Lỗi xóa SupplierCategory: {ex.Message}");
                throw;
            }
        }
        public SupplierCategory Create(Supplier supplier, int categoryId)
        {
            return null;
        }
    }
}