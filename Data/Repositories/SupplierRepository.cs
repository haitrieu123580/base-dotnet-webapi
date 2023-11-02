using System.Collections.Generic;
using System.Linq;
using s002API.Data.Repositories;
using Microsoft.EntityFrameworkCore; // Thêm using này
using s002API.Models;
using System;

namespace s002API.Data.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        // private readonly ISupplierRepository _supplierRepo;
        private readonly AppDbContext _context; // Đối tượng cơ sở dữ liệu

        public SupplierRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SupplierCategory> GetSupplierCategories()
        {
            return _context.SupplierCategories
                    .Include(sc => sc.Supplier)
                    .Include(sc => sc.Category)
                    .ToList();
        }
        public bool isExistSupplier(int id)
        {
            return true;
        }
        public SupplierCategory GetSupplierById(int id)
        {
            return null;
        }
    }
}