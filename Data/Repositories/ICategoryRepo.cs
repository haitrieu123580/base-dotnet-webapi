

using System.Collections.Generic;
using s002API.Models;

namespace s002API.Data.Repositories
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetCategories();
    }
}