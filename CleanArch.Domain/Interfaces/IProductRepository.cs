using CleanArch.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface IProductRepository
    {
        //GET e GetById
        Task<IEnumerable<Product>> GetCategoriesAsync();
        Task<Product> GetById(int? id);

        //Buscar produtos de uma categoria
        Task<Product> GetProductCategoryAsync(int? id);

        //POST
        Task<Product> CreateAsync(Product product);

        //UPDATE
        Task<Product> UpdateAsync(Product product);

        //REMOVE
        Task<Product> RemoveAsync(Product product);
    }
}
