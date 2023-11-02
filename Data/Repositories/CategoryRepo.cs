using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using s002API.Models;

namespace s002API.Data.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext _context;
        public CategoryRepo(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetCategories()
        {
            return null;
        }
    }
}