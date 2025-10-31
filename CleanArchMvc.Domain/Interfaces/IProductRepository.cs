using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clean.ArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetByIdAsync(int? id);

        Task<Product> CreateAsync(Product category);
        Task<Product> UpdateAsync(Product category);
        Task<Product> RemoveAsync(Product category);
        
        Task<Product> GetProductCategoryAsync(int? id);
    }
}